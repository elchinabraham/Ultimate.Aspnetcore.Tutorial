using Entities.Exceptions.System;

namespace Entities.Exceptions.Custom;

public sealed class IdParametersBadRequestException : BadRequestException
{
    public IdParametersBadRequestException(): base("Parameter ids is null")
    {
    }
}
