# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.QuotaUsage do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :additional_price,
    :can_use_more,
    :feature,
    :feature_available,
    :included,
    :used
  ]

  @type t :: %__MODULE__{
    :additional_price => integer(),
    :can_use_more => boolean(),
    :feature => String.t,
    :feature_available => boolean(),
    :included => integer(),
    :used => integer()
  }
end

defimpl Poison.Decoder, for: Ory.Model.QuotaUsage do
  def decode(value, _options) do
    value
  end
end

