using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
                bool firstName = UserPattern.ValidateFirstAndLastName("Sachin");
                Assert.AreEqual(firstName, true);
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
                bool firstName = UserPattern.ValidateFirstAndLastName("sachin");
                Assert.AreEqual(firstName, false);
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
                bool firstName = UserPattern.ValidateFirstAndLastName("#achin");
                Assert.AreEqual(firstName, false);
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
                bool firstName = UserPattern.ValidateFirstAndLastName("123achin");
                Assert.AreEqual(firstName, false);
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
                bool firstName = UserPattern.ValidateFirstAndLastName("Si");
                Assert.AreEqual(firstName, false);
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
                bool firstName = UserPattern.ValidateFirstAndLastName("");
                Assert.AreEqual(firstName, false);
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
                bool firstName = UserPattern.ValidateFirstAndLastName(null);
                Assert.AreEqual(firstName, false);
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
                bool lastName = UserPattern.ValidateFirstAndLastName("Dabhade");
                Assert.AreEqual(lastName, true);
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
                bool lastName = UserPattern.ValidateFirstAndLastName("dabhade");
                Assert.AreEqual(lastName, false);
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
                bool lastName = UserPattern.ValidateFirstAndLastName("#dabhade");
                Assert.AreEqual(lastName, false);
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
                bool lastName = UserPattern.ValidateFirstAndLastName("123adfdf");
                Assert.AreEqual(lastName, false);
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
                bool lastName = UserPattern.ValidateFirstAndLastName("Si");
                Assert.AreEqual(lastName, false);
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
                bool lastName = UserPattern.ValidateFirstAndLastName("");
                Assert.AreEqual(lastName, false);
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
                bool lastName = UserPattern.ValidateFirstAndLastName(null);
                Assert.AreEqual(lastName, false);
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
                bool emailId = UserPattern.ValidateEmailId("abc.100@bl.co.in");
                Assert.AreEqual(emailId, true);
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
                bool emailId = UserPattern.ValidateEmailId("abc@bl.co");
                Assert.AreEqual(emailId, true);
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
                bool emailId = UserPattern.ValidateEmailId("abc.100@abc.com.au");
                Assert.AreEqual(emailId, true);
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
                bool emailId = UserPattern.ValidateEmailId("abc@gmail.com.com");
                Assert.AreEqual(emailId, true);
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
                bool emailId = UserPattern.ValidateEmailId("abc+100@gmail.com");
                Assert.AreEqual(emailId, true);
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
                bool emailId = UserPattern.ValidateEmailId("dabhade904@gmail.com.com.in");
                Assert.AreEqual(emailId, false);
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
                bool emailId = UserPattern.ValidateEmailId("abc.100.abc.com.au");
                Assert.AreEqual(emailId, false);
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
                bool emailId = UserPattern.ValidateEmailId("abc@.com.my");
                Assert.AreEqual(emailId, false);
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
                bool emailId = UserPattern.ValidateEmailId("abc123@gmail.a");
                Assert.AreEqual(emailId, false);
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
                bool emailId = UserPattern.ValidateEmailId("abc123@.com");
                Assert.AreEqual(emailId, false);
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
                bool emailId = UserPattern.ValidateEmailId(".abc@abc.com");
                Assert.AreEqual(emailId, false);
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
                bool emailId = UserPattern.ValidateEmailId("abc()*@gmail.com");
                Assert.AreEqual(emailId, false);
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
                bool emailId = UserPattern.ValidateEmailId("abc..2002@gmail.com");
                Assert.AreEqual(emailId, false);
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
                bool emailId = UserPattern.ValidateEmailId("abc.@gmail.com");
                Assert.AreEqual(emailId, false);
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
                bool emailId = UserPattern.ValidateEmailId("abc@abc@gmail.com");
                Assert.AreEqual(emailId, false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void CanNotHaveMultipleEmailTld()
        {
            try
            {
                bool emailId = UserPattern.ValidateEmailId("abc@gmail.com.aa.au");
                Assert.AreEqual(emailId, false);
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
                bool email = UserPattern.ValidateFirstAndLastName("");
                Assert.AreEqual(email, false);
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
                bool email = UserPattern.ValidateFirstAndLastName(null);
                Assert.AreEqual(email, false);
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
                bool mobileNumber = UserPattern.ValidateMobileNumber("91 8888948943");
                Assert.AreEqual(mobileNumber, true);
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
                bool mobileNumber = UserPattern.ValidateMobileNumber("9188888948943");
                Assert.AreEqual(mobileNumber, false);
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
                bool mobileNumber = UserPattern.ValidateMobileNumber("abcdefg");
                Assert.AreEqual(mobileNumber, false);
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
                bool mobileNumber = UserPattern.ValidateFirstAndLastName("");
                Assert.AreEqual(mobileNumber, false);
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
                bool mobileNumber = UserPattern.ValidateFirstAndLastName(null);
                Assert.AreEqual(mobileNumber, false);
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
                bool userPassword = UserPattern.ValidatePassword("Pass12@a");
                Assert.AreEqual(userPassword, true);
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
                bool userPassword = UserPattern.ValidatePassword("pass@123");
                Assert.AreEqual(userPassword, false);
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
                bool userPassword = UserPattern.ValidatePassword("pass123");
                Assert.AreEqual(userPassword, false);
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
                bool userPassword = UserPattern.ValidatePassword("pass123");
                Assert.AreEqual(userPassword, false);
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
                bool password = UserPattern.ValidatePassword("sachinA");
                Assert.AreEqual(password, false);
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
                bool password = UserPattern.ValidatePassword("sIchin12");
                Assert.AreEqual(password, false);
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
                bool password = UserPattern.ValidateFirstAndLastName("");
                Assert.AreEqual(password, false);
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
                bool password = UserPattern.ValidateFirstAndLastName(null);
                Assert.AreEqual(password, false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}