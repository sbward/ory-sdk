# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.AcceptOAuth2ConsentRequest do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :grant_access_token_audience,
    :grant_scope,
    :handled_at,
    :remember,
    :remember_for,
    :session
  ]

  @type t :: %__MODULE__{
    :grant_access_token_audience => [String.t] | nil,
    :grant_scope => [String.t] | nil,
    :handled_at => DateTime.t | nil,
    :remember => boolean() | nil,
    :remember_for => integer() | nil,
    :session => Ory.Model.AcceptOAuth2ConsentRequestSession.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.AcceptOAuth2ConsentRequest do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:session, :struct, Ory.Model.AcceptOAuth2ConsentRequestSession, options)
  end
end

