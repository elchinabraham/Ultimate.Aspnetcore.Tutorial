namespace Entities.Exceptions.System;

public abstract class BadRequestException : Exception
{
    protected BadRequestException(string message)
    : base(message)
    {
    }
}
