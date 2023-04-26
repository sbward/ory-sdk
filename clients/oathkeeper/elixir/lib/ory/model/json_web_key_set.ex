# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.JsonWebKeySet do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :keys
  ]

  @type t :: %__MODULE__{
    :keys => [Ory.Model.JsonWebKey.t] | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.JsonWebKeySet do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:keys, :list, Ory.Model.JsonWebKey, options)
  end
end

