using Entities.Exceptions.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Exceptions.Custom
{
    public sealed class EmployeeBadRequestException : BadRequestException
    {
        public EmployeeBadRequestException(string message) : base(message)
        {
        }
    }
}
