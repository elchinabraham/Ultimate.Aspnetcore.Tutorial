using Entities.Exceptions.System;

namespace Entities.Exceptions.Custom;

public sealed class CollectionByIdsBadRequestException : BadRequestException
{
    public CollectionByIdsBadRequestException() : base("Collection count mismatch comparing to ids.")
    {
    }
}
