using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using UserRegistration;
using UserRegistrationProblem;
namespace ValidateUserRegistration
{
    [TestClass]
    public class UserRegistrationTest
    {
        /// <summary>
        /// Test cases for First Name
        /// </summary>
        [TestMethod]
        public void WhenGivenFirstNameStartWithUppercaseReturnTrue()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "Sachin" });
                object firstName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, firstName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenFirstNameStartLowerCaseShouldReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "sachin" });
                object firstName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, firstName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenFirstName_WithSpecialSymbol_ShouldReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "#achin" });
                object firstName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, firstName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenFirstName_WithNumber_ShouldReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "123achin" });
                object firstName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, firstName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenFirstName_IsLessThanThreeCharacter()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "Si" });
                object firstName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, firstName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void GivenFirstName_When_Empty_Should_Throw_CustomException()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "" });
                object firstName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, firstName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void GivenFirstName_When_Null_Should_Throw_CustomException()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { null });
                object firstName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, firstName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Test case for Last Name
        /// </summary>

        [TestMethod]
        public void WhenGivenLastNameStartWithUppercaseReturnTrue()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "Dabhade" });
                object lastName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, lastName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenLastNameStartLowerCaseShouldReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "dabhade" });
                object lastName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, lastName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenLastName_WithSpecialSymbol_ShouldReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "#dabhade" });
                object lastName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, lastName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenLastName_WithNumber_ShouldReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "123adfdf" });
                object lastName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, lastName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenLastName_IsLessThanThreeCharacter()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "Fi" });
                object lastName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, lastName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void GivenLastName_When_Empty_Should_Throw_CustomException()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "" });
                object lastName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, lastName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void GivenLastName_When_Null_Should_Throw_CustomException()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { null });
                object lastName = UserPattern.ValidateFirstAndLastName(expected);
                Assert.AreEqual(expected, lastName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Test Cases for Email validation 
        /// </summary>
        /// 
        /// Email Validation Valid Scenario
        [TestMethod]
        public void WhenGivenEmail_IfContainsMondatoryParts_ShouldReturnValidEmail()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc.100@bl.co.in" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenEmail_IfHasOptionalPart_ShouldReturnValidEmail()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc@bl.co" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void ShouldReturnTrue()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc.100@abc.com.au" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void WhenItHasTwoDomains()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc@gmail.com.com" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WithPlusSign_ShouldReturnTrue()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc+100@gmail.com" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Email validation Invalid Scenario
        [TestMethod]
        public void WhenGivenEmail_IfInvalid_ShouldReturnInvalidEmail()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "dabhade904@gmail.com.com.in" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void MustContainsAtSignSymbol_ShouldReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc.100.abc.com.au" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void ShouldNotStartWithDot_ReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc@.com.my" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void IsNotValidContainsAtLeastTwoCharacters_ShouldReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc123@gmail.a" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void TldCantStartWithDot()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc123@.com" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void EmailFirststCharacterCanNotStartWith()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { ".abc@abc.com" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void EmailIsOnlyAllowCharacterDigitUnderscoreAndDash()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc()*@gmail.com" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void DoubleDotsAreNotAllow()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc..2002@gmail.com" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void EmailLastCharacterCanNotEndWithDot()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc.@gmail.com" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void DoubleAtSignAreNotAllow()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc@abc@gmail.com" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void Can_Not_Have_Multiple_Email_Tld()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abc@gmail.com.aa.au" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void GivenEmail_When_Empty_Should_Throw_CustomException()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void GivenEmail_When_Null_Should_Throw_CustomException()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { null });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(expected, emailId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        [TestMethod]
        public void GivenEmail_When_Multiple_Email_Should_Validate_Email()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "Sachin@gmail.com","sachind9765@rediffmail.com" });
                object emailId = UserPattern.ValidateEmailId(expected);
                Assert.AreEqual(emailId,expected);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Test cases for Mobile validation
        /// </summary>
        [TestMethod]
        public void WhenGivenMobileNumber_WhenProper_ShouldReturnTrue()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "91 8888948943" });
                object mobileNumber = UserPattern.ValidateMobileNumber(expected);
                Assert.AreEqual(expected, mobileNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void WhenGivenMobileNumber_WhenNotGivenSpace_ShouldReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "9188888948943" });
                object mobileNumber = UserPattern.ValidateMobileNumber(expected);
                Assert.AreEqual(expected, mobileNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenMobileNumber_WhenPassCharacter_ShouldReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "abcdefg" });
                object mobileNumber = UserPattern.ValidateMobileNumber(expected);
                Assert.AreEqual(expected, mobileNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void GivenMobileNumber_When_Empty_Should_Throw_CustomException()
        {
            try
            {
                List<string> expected = new List<string>(new string[] {"" });
                object mobileNumber = UserPattern.ValidateMobileNumber(expected);
                Assert.AreEqual(expected, mobileNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void GivenMobileNumber_When_Null_Should_Throw_CustomException()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { null });
                object mobileNumber = UserPattern.ValidateMobileNumber(expected);
                Assert.AreEqual(expected, mobileNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Test cases for validate password
        /// </summary>
        [TestMethod]
        public void WhenGivenPassword_IfMinimumEightCharacters_ShouldReturnTrue()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "Pass12@a" });
                object userPassword = UserPattern.ValidatePassword(expected);
                Assert.AreEqual(expected, userPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenPassword_WhenSpecialSymbol_ShouldReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "pass@123" });
                object userPassword = UserPattern.ValidatePassword(expected);
                Assert.AreEqual(expected, userPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenPassword_IfCharacterLessEight_ShouldReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "pass123" });
                object userPassword = UserPattern.ValidatePassword(expected);
                Assert.AreEqual(expected, userPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenPasswordUpper_IfCharacterLessEight_ShouldReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "pass123" });
                object userPassword = UserPattern.ValidatePassword(expected);
                Assert.AreEqual(expected, userPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void WhenGivenPassword_IfNoNumericValue_ReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "sachinA" });
                object userPassword = UserPattern.ValidatePassword(expected);
                Assert.AreEqual(expected, userPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void ValidatePswd_IfNoSpecialSymbol_ReturnFalse()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "sIchin12" });
                object userPassword = UserPattern.ValidatePassword(expected);
                Assert.AreEqual(expected, userPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void Given_Password_When_Empty_Should_Throw_CustomException()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { "" });
                object password = UserPattern.ValidatePassword(expected);
                Assert.AreEqual(expected, password);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void GivenPassword_When_Null_Should_Throw_CustomException()
        {
            try
            {
                List<string> expected = new List<string>(new string[] { null });
                object password = UserPattern.ValidatePassword(expected);
                Assert.AreEqual(expected, password);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void Given_User_Registration_ClassName_Should_Return_User_Registration_Object()
        {
            object expected = new UserPattern();
            object obj = UserRegistrationFactory.CreateUserRegistration("UserRegistrationProblem.UserPattern", "UserPattern", "");
            expected.Equals(obj);
        }
    }
}