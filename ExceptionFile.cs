using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationdaylambda_24
{
    public class ExceptionFile
    {
        public ExceptionFile() { }  
    }
    public class InvalidFirstNameException : Exception
    {
        public InvalidFirstNameException(string message) : base(message)
        {
        }
    }

    public class InvalidLastNameException : Exception
    {
        public InvalidLastNameException(string message) : base(message)
        {
        }
    }

    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message)
        {
        }
    }

    public class InvalidPhoneException : Exception
    {
        public InvalidPhoneException(string message) : base(message)
        {
        }
    }

    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string message) : base(message)
        {
        }
    }
}
