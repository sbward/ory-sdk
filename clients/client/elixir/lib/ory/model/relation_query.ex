# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.RelationQuery do
  @moduledoc """
  Relation Query
  """

  @derive [Poison.Encoder]
  defstruct [
    :namespace,
    :object,
    :relation,
    :subject_id,
    :subject_set
  ]

  @type t :: %__MODULE__{
    :namespace => String.t | nil,
    :object => String.t | nil,
    :relation => String.t | nil,
    :subject_id => String.t | nil,
    :subject_set => Ory.Model.SubjectSet.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.RelationQuery do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:subject_set, :struct, Ory.Model.SubjectSet, options)
  end
end

