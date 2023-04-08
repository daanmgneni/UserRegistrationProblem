using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; 
using System.Threading.Tasks;
 

namespace UserRegistrationProgram
{
    public class UserRegistrationCode
    {
        public static string FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Email = "^[a-z0-9._+-]+@[a-z0-9.-]+\\.[a-z.]{2,}$";

        //CHECK 1ST NAME
        public bool ValidateFName(string FName)
        {
            return Regex.IsMatch(FName, FirstName); 
        }
       

        //CHECK LAST NAME
        public bool ValidateLName(string LName)
        {
            return Regex.IsMatch(LName, FirstName);
        }

        //CHECK EMAIL
        public bool ValidateEmail(string MailId)
        {
            return Regex.IsMatch(MailId, Email);
        }
    }
}
