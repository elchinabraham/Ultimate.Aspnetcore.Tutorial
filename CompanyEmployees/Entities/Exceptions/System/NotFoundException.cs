namespace Entities.Exceptions.System
{
    public abstract class NotFoundException : Exception
    {
        protected NotFoundException(string message)
        : base(message)
        { }
    }
}
