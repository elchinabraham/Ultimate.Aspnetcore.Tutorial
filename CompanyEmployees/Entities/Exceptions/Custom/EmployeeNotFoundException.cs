using Entities.Exceptions.System;

namespace Entities.Exceptions.Custom
{
    public class EmployeeNotFoundException : NotFoundException
    {
        public EmployeeNotFoundException(Guid employeeId) 
            : base($"Employee with id: {employeeId} doesn't exist in the database.")
        {
        }
    }
}
