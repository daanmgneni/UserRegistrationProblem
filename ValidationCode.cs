using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationdaylambda_24
{
    public class ValidationCode
    {
        //FIRST NAME
        public string ValidateFirstName(string firstName)
        {
            Func<string, bool> FirstName = name => name.Length >= 3 && char.IsUpper(name[0]);
            //Console.Write("Please enter your first name: ");
            //string firstName = Console.ReadLine();
            if (FirstName(firstName) == true)
            {
                return "Valid first name!";
            }
            else
            {
                return "Invalid first name. Please enter a first name starting with a capital letter and at least 3 characters.";
            }
        }

        //LAST NAME
        public string ValidateLastName(string lastName)
        {
            Func<string, bool> LastName = name => name.Length >= 3 && char.IsUpper(name[0]);
            //Console.Write("Please enter your last name: ");
            //string lastName = Console.ReadLine();
            if (LastName(lastName) == true)
            {
                return "Valid last name!";
            }
            else
            {
                return "Invalid last name. Please enter a last name starting with a capital letter and at least 3 characters.";
            }
        }

        // EMAIL ADDRESS
        public string ValidateEmail(string email)
        {
            Func<string, bool> Email = email1 =>
            {
                string pattern = @"^[0-9a-z._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(email1);
            };

            //Console.Write("Please enter your email address: ");
            //string email = Console.ReadLine();
            if (Email(email) == true)
            {
                return "Valid email!";
            }
            else
            {
                return "Invalid email. Please enter a valid email address.";
            }
        }

        //PHONE NUMBER
        public string ValidatePhone(string phone)
        {
            Func<string, bool> PhoneNumber = phoneNum =>
            {
                string pattern = @"^[1-9]{2} [0-9]{10}$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(phoneNum);
            };
            //Console.Write("Please enter your Phone Number: ");
            //string phone = Console.ReadLine();
            if (PhoneNumber(phone) == true)
            {
                return "Valid Phone Number!";
            }
            else
            {
                return "Invalid Phone Number. Please enter a valid Phone Number.";
            }
        }

        //PASSWORD
        public string ValidatePassword(string password)
        {
            Func<string, bool> Password = pass =>
            {
                string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&*()]).{8,}$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(pass);
            };
            //Console.Write("Please enter your password: ");
            //string password = Console.ReadLine();
            if (Password(password) == true)
            {
                return "Valid Password!";
            }
            else
            {
                return "Invalid Password. Please enter a valid Password.";
            }
        }

        // validate each email sample using lambda expression
        public void ValidateAllEmailSample()
        {
            string[] emailSamples = new string[] { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };

            Func<string, bool> Email = email1 =>
            {
                string pattern = @"^[0-9a-z._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(email1);
            };


            Array.ForEach(emailSamples, email => {
                Console.Write("Please enter your email address: ");
                string email2 = Console.ReadLine();


                if (Email(email2) == true)
                {
                    Console.WriteLine(email2 + " passed validation.");
                }
                else
                {
                    Console.WriteLine(email2 + " failed validation.");
                }
            });

        }
 }
