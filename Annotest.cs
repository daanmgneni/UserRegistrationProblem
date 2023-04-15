using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrartionWithAnotation
{
    public class Annotest
    {
        public static void Display()
        {
            CheckValidaton check = new CheckValidaton();
            Console.WriteLine("Enter Your FirstName");
            check.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your LastName");
            check.LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Email");
            check.Email = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number");
            check.Phone = Console.ReadLine();
            Console.WriteLine("Enter Your Password");
            check.Password = Console.ReadLine();




            string[] emailSamples = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            ValidationContext con = new ValidationContext(check);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(check, con, results, true);
            if (!valid)
            {
                foreach (ValidationResult i in results)
                {
                    Console.WriteLine("Member Name : {0}", i.MemberNames.First());
                    Console.WriteLine("Error Message : {0}", i.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine(" FirstName :" + check.FirstName + "\n LasttName :" + check.LastName + "\n email :" + check.Email + "\n PhoneNumber : " + check.Phone + "\n Password : " + check.Password);
              
                foreach (string email in emailSamples)
                {
                    Console.WriteLine("{0} : {1}", email, (new EmailAddressAttribute().IsValid(email) ? "Valid" : "Invalid"));
                }
            }
        }
    }
}
