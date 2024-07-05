#!/bin/bash

set -Eeuxo pipefail
cd "$( dirname "${BASH_SOURCE[0]}" )/.."

source scripts/prep.sh

to_git() {
  lang=$1
  if [ -z ${3+x} ]; then
    gitdir=$(mktemp -d -t "${GIT_REPO}-${lang}.XXXXXX")
  else
    gitdir="$3"
  fi
  srcdir="clients/${PROJECT}/${lang}"

  repo="ory/${GIT_REPO}-${lang}"

  if [[ $(curl -sw '%{http_code}' -o /dev/null "https://github.com/${repo}") == "200" ]]; then
    mkdir -p ${gitdir} || true
    git clone "git@github.com:${repo}.git" "${gitdir}" --branch master --single-branch --depth 1
  else
    (cd "${gitdir}"; git init; gh repo create "${repo}" --enable-wiki=false --public -y -l Apache-2.0 -d "Autogenerated $PROJECT SDK.")
  fi

  (cd "${gitdir}"; git checkout -b "release-$(date +%s)" master)

  # rm -rf "${srcdir:?}/*"
  rm -r -f -v ${gitdir:?}/*
  ls -la "${gitdir}"
  cp -R "${srcdir}/." "${gitdir}"
  ls -la "${gitdir}"

  case $lang in
    dart)
      export INSTALL='Install via [Dart (pub)](https://pub.dev/packages/${DART_PUB_NAME})'
      ;;
    dotnet)
      export INSTALL="Install via [.NET (nuget)](https://www.nuget.org/packages/${DOTNET_PACKAGE_NAME}/)"
      ;;
    golang)
      export INSTALL='```
go get https://github.com/ory/${GIT_REPO}
```'
      ;;
    java)
      export INSTALL="[Java (Maven Central)](https://search.maven.org/artifact/${JAVA_GROUP_ID}/${JAVA_ARTIFACT_ID})"
      ;;
    typescript)
      export INSTALL='```
npm i ${NPM_NAME}
```'
      ;;
    php)
      export INSTALL="[PHP (Packagist)](https://packagist.org/packages/${PHP_PACKAGE_NAME})"
      ;;
    python)
      export INSTALL="[Python (pip)](https://pypi.org/project/${PYTHON_PROJECT_NAME}/)"
      ;;
    ruby)
      export INSTALL="[Ruby (Gem)](https://rubygems.org/gems/${RUBY_PROJECT_NAME}/)"
      ;;
    rust)
      export INSTALL="[Rust (Crate)](https://crates.io/crates/${RUST_PACKAGE_NAME}/)"
      ;;
    elixir)
      export INSTALL="[Elixir (Hex)](https://hex.pm/packages/${ELIXIR_PACKAGE_NAME}/)"
      ;;
    PATTERN_N)
      STATEMENTS
      ;;

    *)
      export INSTALL="package repository is missing, please open an issue about this."
      ;;
  esac

  rm "${gitdir}/README.md" || true
  LANG=$lang \
    GIT_REPO=${repo} \
    envsubst < "config/README.md" > "${gitdir}/README.md"

  (cd "${gitdir}"; git add -A || true; (git commit -a  -F- <<EOF
autogen: regenerate OpenAPI client for ${VERSION}

Version: ${VERSION}
EOF
) || true)

  if [ "${2}" = "yes" ]; then
    (cd "${gitdir}"; git tag -a "${VERSION}" -m "${VERSION}")
  else
    # empty, do nothing!
    echo "not tagging"
  fi

  cp -f LICENSE "${gitdir}/LICENSE"

  (cd "${gitdir}"; git push origin --tags HEAD:master)
}

upstream() {
  git add -A
  git commit --allow-empty -a -m "chore: regenerate OpenAPI client ${VERSION}"
  git push origin
}

typescript() {
  dir="clients/${PROJECT}/typescript"

  (cd "${dir}"; npm install; npm run build)
  (cd "${dir}"; npm version -f --no-git-tag-version "${VERSION}" || true; npm publish --access public)

  to_git "js" "yes"
}

typescript_fetch() {
  dir="clients/${PROJECT}/typescript-fetch"

  (cd "${dir}"; npm install; npm run build)
  (cd "${dir}"; npm version -f --no-git-tag-version "${VERSION}" || true; npm publish --access public)

  to_git "typescript-fetch" "yes"
}

java() {
  gitdir=$(mktemp -d -t "${GIT_REPO}-java.XXXXXX")
  to_git "java" "no" "$gitdir"

  (cd "${gitdir}"; mvn clean)

  version=$(echo "${VERSION}" | sed "s/^v//")

  (cd "${gitdir}"; mvn release:prepare \
    -Dresume=false \
    -DreleaseVersion="${version}" \
    -Dtag="${VERSION}" \
    -DdevelopmentVersion="${version}-SNAPSHOT" \
    -Darguments="-Dgpg.passphrase=${MVN_PGP_PASSPHRASE} -Dgpg.keyname=${MVN_PGP_KEYNAME}")

  (cd "${gitdir}"; mvn release:perform)
  (cd "${gitdir}"; git push origin --tags HEAD:master)
}

php() {
  dir="clients/${PROJECT}/php"

  (cd "${dir}"; composer install)
  to_git "php" "yes"
}

ruby() {
  dir="clients/${PROJECT}/ruby"

  gemspec="ory-${PROJECT}-client.gemspec"
  gemfile="ory-${PROJECT}-client-${GEM_VERSION}.gem"
  if [ ${PROJECT} == "client" ]; then
    gemspec="ory-client.gemspec"
    gemfile="ory-client-${GEM_VERSION}.gem"
  fi

  (cd "${dir}"; rm *.gem || true; gem build "${gemspec}"; gem push "${gemfile}")
  to_git "ruby" "yes"
}

golang() {
  dir="clients/${PROJECT}/go"

  (cd "${dir}"; go mod tidy -compat=1.17)
  to_git "go" "yes"
}

python() {
  dir="clients/${PROJECT}/python"
  (cd "${dir}"; rm -rf "dist" || true; python3 setup.py sdist bdist_wheel; python3 -m twine upload "dist/*")
  to_git "python" "yes"
}

dotnet() {
  dir="clients/${PROJECT}/dotnet"

  (cd "${dir}"; VERSION=${RAW_VERSION} command dotnet pack -o .)

  ls -la ${dir}
  nupkg_name="Ory.${PROJECT_UCF}.Client.${RAW_VERSION}.nupkg"
  if [ ${PROJECT} == "client" ]; then
    nupkg_name="Ory.Client.${RAW_VERSION}.nupkg"
  fi

  (cd "${dir}"; command dotnet nuget push "${nupkg_name}" \
  --api-key "${NUGET_API_KEY}" \
  --source https://api.nuget.org/v3/index.json)
  to_git "dotnet" "yes"
}

dart() {
  dir="clients/${PROJECT}/dart"
  mkdir -p "$HOME/.pub-cache" || true
  set +x

  if [ -z ${DART_SERVICE_ACCOUNT+x} ]; then echo "Variable DART_SERVICE_ACCOUNT MUST be set."; fi

  echo "$DART_SERVICE_ACCOUNT" | base64 -d > "$HOME/.pub-cache/key-file.json"
  set -x
  ls -lah "$HOME/.pub-cache/"
  set +x

  # To generate this key run:
  #
  #  gcloud iam service-accounts keys create key-file.json \
  #    --project=ory-web \
  #    --iam-account=pub-dev@ory-web.iam.gserviceaccount.com
  #  base64 key-file.json | pbcopy
  #
  # And copy it into the DART_SERVICE_ACCOUNT secret.

  gcloud auth activate-service-account --key-file="$HOME/.pub-cache/key-file.json"
  gcloud auth print-identity-token \
    --audiences=https://pub.dev \
    | dart pub token add https://pub.dev
  set -x

  (cd "${dir}"; VERSION=${RAW_VERSION} command dart pub publish --force)
  to_git "dart" "yes"
}

rust() {
  dir="clients/${PROJECT}/rust"

  cargo login "${CARGO_TOKEN}"

  (cd "${dir}"; VERSION=${RAW_VERSION} command cargo publish --allow-dirty)
  to_git "rust" "yes"
}

elixir() {
  dir="clients/${PROJECT}/elixir"

  (cd "${dir}"; mix local.rebar --force)
  (cd "${dir}"; mix local.hex --force)
  (cd "${dir}"; mix deps.get)

  (cd "${dir}"; mix hex.publish --yes)
}


FAIL=0

echo "starting"

python || let "FAIL+=1"
ruby || let "FAIL+=1"
golang || let "FAIL+=1"
php || let "FAIL+=1"
typescript || let "FAIL+=1"
typescript_fetch || let "FAIL+=1"
dart || let "FAIL+=1"
rust || let "FAIL+=1"
elixir || let "FAIL+=1"
java || let "FAIL+=1"
dotnet || let "FAIL+=1"
upstream || let "FAIL+=1"

echo "$FAIL"

if [ "$FAIL" == "0" ]; then
  echo "Everything ran to completion!"
else
  echo "One or more subtasks failed to complete."
  exit 1
fi
