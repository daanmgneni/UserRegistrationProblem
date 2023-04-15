using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrartionWithAnotation
{
    public class CheckValidaton
    {
        //FIRST NAME
        // [Required(ErrorMessage = "Property check {0} is required")]
        // [StringLength(100,MinimumLength =3 ,ErrorMessage = "Name should be minimum 3 character" )]
        [RegularExpression("^[A-Z]{1}[A-Za-z]{2,}$", ErrorMessage = "Name should be minimum 3 character and start with caps")]
        [DataType(DataType.Text)]
        
        public string FirstName { get; set; }


        //LAST NAME
        [RegularExpression("^[A-Z]{1}[A-Za-z]{2,}$", ErrorMessage = "Name should be minimum 3 character and start with caps")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }


        //EMAIL
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        //PHONE
        [RegularExpression("^[1-9]{2} [0-9]{10}$",ErrorMessage = "Number must be 10 digit only with country code")]
        [DataType(DataType.PhoneNumber)]
        [Phone]

        public string Phone { get; set; }

        //PASWORD
        [RegularExpression("^(?=.*[A-Z]).{8,}$", ErrorMessage ="password minimum 8 character and atleast 1 upper case")]
        [DataType(DataType.Password)]
        [PasswordPropertyText]

        public string Password { get; set; }    

    }
}
