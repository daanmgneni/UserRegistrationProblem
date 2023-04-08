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
        public bool ValidateFName(string FName)
        {
            return Regex.IsMatch(FName, FirstName); 
        }
    }
}
