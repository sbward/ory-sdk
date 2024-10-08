# coding: utf-8

"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

    The version of the OpenAPI document: v1.15.6
    Contact: support@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


from __future__ import annotations
import pprint
import re  # noqa: F401
import json

from datetime import datetime
from pydantic import BaseModel, ConfigDict, Field, StrictInt, StrictStr, field_validator
from typing import Any, ClassVar, Dict, List, Optional
from ory_client.models.courier_message_status import CourierMessageStatus
from ory_client.models.courier_message_type import CourierMessageType
from ory_client.models.message_dispatch import MessageDispatch
from typing import Optional, Set
from typing_extensions import Self

class Message(BaseModel):
    """
    Message
    """ # noqa: E501
    body: StrictStr
    channel: Optional[StrictStr] = None
    created_at: datetime = Field(description="CreatedAt is a helper struct field for gobuffalo.pop.")
    dispatches: Optional[List[MessageDispatch]] = Field(default=None, description="Dispatches store information about the attempts of delivering a message May contain an error if any happened, or just the `success` state.")
    id: StrictStr
    recipient: StrictStr
    send_count: StrictInt
    status: CourierMessageStatus
    subject: StrictStr
    template_type: StrictStr = Field(description=" recovery_invalid TypeRecoveryInvalid recovery_valid TypeRecoveryValid recovery_code_invalid TypeRecoveryCodeInvalid recovery_code_valid TypeRecoveryCodeValid verification_invalid TypeVerificationInvalid verification_valid TypeVerificationValid verification_code_invalid TypeVerificationCodeInvalid verification_code_valid TypeVerificationCodeValid stub TypeTestStub login_code_valid TypeLoginCodeValid registration_code_valid TypeRegistrationCodeValid")
    type: CourierMessageType
    updated_at: datetime = Field(description="UpdatedAt is a helper struct field for gobuffalo.pop.")
    additional_properties: Dict[str, Any] = {}
    __properties: ClassVar[List[str]] = ["body", "channel", "created_at", "dispatches", "id", "recipient", "send_count", "status", "subject", "template_type", "type", "updated_at"]

    @field_validator('template_type')
    def template_type_validate_enum(cls, value):
        """Validates the enum"""
        if value not in set(['recovery_invalid', 'recovery_valid', 'recovery_code_invalid', 'recovery_code_valid', 'verification_invalid', 'verification_valid', 'verification_code_invalid', 'verification_code_valid', 'stub', 'login_code_valid', 'registration_code_valid']):
            raise ValueError("must be one of enum values ('recovery_invalid', 'recovery_valid', 'recovery_code_invalid', 'recovery_code_valid', 'verification_invalid', 'verification_valid', 'verification_code_invalid', 'verification_code_valid', 'stub', 'login_code_valid', 'registration_code_valid')")
        return value

    model_config = ConfigDict(
        populate_by_name=True,
        validate_assignment=True,
        protected_namespaces=(),
    )


    def to_str(self) -> str:
        """Returns the string representation of the model using alias"""
        return pprint.pformat(self.model_dump(by_alias=True))

    def to_json(self) -> str:
        """Returns the JSON representation of the model using alias"""
        # TODO: pydantic v2: use .model_dump_json(by_alias=True, exclude_unset=True) instead
        return json.dumps(self.to_dict())

    @classmethod
    def from_json(cls, json_str: str) -> Optional[Self]:
        """Create an instance of Message from a JSON string"""
        return cls.from_dict(json.loads(json_str))

    def to_dict(self) -> Dict[str, Any]:
        """Return the dictionary representation of the model using alias.

        This has the following differences from calling pydantic's
        `self.model_dump(by_alias=True)`:

        * `None` is only added to the output dict for nullable fields that
          were set at model initialization. Other fields with value `None`
          are ignored.
        * Fields in `self.additional_properties` are added to the output dict.
        """
        excluded_fields: Set[str] = set([
            "additional_properties",
        ])

        _dict = self.model_dump(
            by_alias=True,
            exclude=excluded_fields,
            exclude_none=True,
        )
        # override the default output from pydantic by calling `to_dict()` of each item in dispatches (list)
        _items = []
        if self.dispatches:
            for _item in self.dispatches:
                if _item:
                    _items.append(_item.to_dict())
            _dict['dispatches'] = _items
        # puts key-value pairs in additional_properties in the top level
        if self.additional_properties is not None:
            for _key, _value in self.additional_properties.items():
                _dict[_key] = _value

        return _dict

    @classmethod
    def from_dict(cls, obj: Optional[Dict[str, Any]]) -> Optional[Self]:
        """Create an instance of Message from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "body": obj.get("body"),
            "channel": obj.get("channel"),
            "created_at": obj.get("created_at"),
            "dispatches": [MessageDispatch.from_dict(_item) for _item in obj["dispatches"]] if obj.get("dispatches") is not None else None,
            "id": obj.get("id"),
            "recipient": obj.get("recipient"),
            "send_count": obj.get("send_count"),
            "status": obj.get("status"),
            "subject": obj.get("subject"),
            "template_type": obj.get("template_type"),
            "type": obj.get("type"),
            "updated_at": obj.get("updated_at")
        })
        # store additional fields in additional_properties
        for _key in obj.keys():
            if _key not in cls.__properties:
                _obj.additional_properties[_key] = obj.get(_key)

        return _obj


