# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Kratos.Model.InlineResponse200 do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :"status"
  ]

  @type t :: %__MODULE__{
    :"status" => String.t
  }
end

defimpl Poison.Decoder, for: Kratos.Model.InlineResponse200 do
  def decode(value, _options) do
    value
  end
end
