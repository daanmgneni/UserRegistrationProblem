using UserRegistrationdaylambda_24;
namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        //HAPPY TEST CASE
        [TestMethod]
            public void ValidateUserEntry_ValidInputs_ReturnsValidMessages()
            {
                //ARRNGE
                string firstName = "Aakanksha";
                string lastName = "Pandey";
                string email = "aakanksha@gmail.com";
                string phone = "91 1234567890";
                string password = "Abcd@1234.com";

                //ACT
                ValidationCode validationCode = new ValidationCode();
                string firstNameValidationResult = validationCode.ValidateFirstName(firstName);
                var lastNameValidationResult = validationCode.ValidateLastName(lastName);
                var emailValidationResult = validationCode.ValidateEmail(email);
                var phoneValidationResult = validationCode.ValidatePhone(phone);
                var passwordValidationResult = validationCode.ValidatePassword(password);

                //ASSERT
                // Assert.AreEqual("Valid first name!", firstNameValidationResult);

                Assert.AreEqual("Valid last name!", lastNameValidationResult);
                Assert.AreEqual("Valid email!", emailValidationResult);
                Assert.AreEqual("Valid Phone Number!", phoneValidationResult);
                Assert.AreEqual("Valid Password!", passwordValidationResult);
            }
        /*
            //SAD TEST CASE
            [TestMethod]
            public void ValidateUserEntry_ValidInputs_ReturnsInValidMessages()
            {
                //ARRNGE
                string firstName = "Aa";
                string lastName = "dey";
                string email = "aakanks.com";
                string phone = "911234567890";
                string password = "Ab234";
                //ACT
                ValidationCode validationCode = new ValidationCode();
                string firstNameValidationResult = validationCode.ValidateFirstName(firstName);
                var lastNameValidationResult = validationCode.ValidateLastName(lastName);
                var emailValidationResult = validationCode.ValidateEmail(email);
                var phoneValidationResult = validationCode.ValidatePhone(phone);
                var passwordValidationResult = validationCode.ValidatePassword(password);
                //ASSERT
                
                Assert.AreEqual("Invalid first name. Please enter a first name starting with a capital letter and at least 3 characters.", firstNameValidationResult);
                Assert.AreEqual("Invalid last name. Please enter a last name starting with a capital letter and at least 3 characters.", lastNameValidationResult);
                Assert.AreEqual("Invalid email. Please enter a valid email address.", emailValidationResult);
                Assert.AreEqual("Invalid Phone Number. Please enter a valid Phone Number.", phoneValidationResult);
                Assert.AreEqual("Invalid Password. Please enter a valid Password.", passwordValidationResult);
            }
        */

        //TEST CASE FOR EMAIL
        [TestMethod]
        public void ValidateUserEntry_ValidInputs_ReturnsValidEmail()
        {
            //ARRNGE
           
            string email2 = "aakanksha@gmail.com";
          

            //ACT
            ValidationCode validationCode = new ValidationCode();

            var AllEmailValidationResult = validationCode.ValidateAllEmailSample(email2);

            //ASSERT
           
            Assert.AreEqual("your email passed validation", AllEmailValidationResult);
           
        }

        [TestMethod]
        public void ValidateUserEntry_InvalidInputs_ThrowsCustomExceptions()
        {
            // Arrange
            string firstName = "Aa";
            string lastName = "dey";
            string email = "aakanks.com";
            string phone = "911234567890";
            string password = "Ab234";
            ValidationCode validationCode = new ValidationCode();

            // Assert
            Assert.ThrowsException<InvalidFirstNameException>(() =>
            {
                // Act
                validationCode.ValidateFirstName(firstName);
            });

            Assert.ThrowsException<InvalidLastNameException>(() =>
            {
                // Act
                validationCode.ValidateLastName(lastName);
            });

            Assert.ThrowsException<InvalidEmailException>(() =>
            {
                // Act
                validationCode.ValidateEmail(email);
            });

            Assert.ThrowsException<InvalidPhoneException>(() =>
            {
                // Act
                validationCode.ValidatePhone(phone);
            });

            Assert.ThrowsException<InvalidPasswordException>(() =>
            {
                // Act
                validationCode.ValidatePassword(password);
            });
        }



    }
}
