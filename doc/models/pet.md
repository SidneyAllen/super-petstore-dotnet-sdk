
# Pet

## Structure

`Pet`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long` | Required | a unique identifier for a Pet |
| `Name` | `string` | Required | the name lovingly given to the pet |
| `PetType` | [`PetTypeEnum?`](../../doc/models/pet-type-enum.md) | Optional | the type of pets allowed |

## Example (as JSON)

```json
{
  "id": 1234,
  "name": "Fido",
  "petType": "dog"
}
```

