using Entities.Exceptions.System;

namespace Entities.Exceptions.Custom;

public sealed class CompanyBadRequestException : BadRequestException
{
    public CompanyBadRequestException(string message) : base(message)
    {
    }
}
