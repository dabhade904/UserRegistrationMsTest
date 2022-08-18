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
            bool firstName = UserPattern.ValidateFirstAndLastName("Sachin");
            Assert.AreEqual(firstName, true);
        }

        [TestMethod]
        public void WhenGivenFirstNameStartLowerCaseShouldReturnFalse()
        {
            bool firstName = UserPattern.ValidateFirstAndLastName("sachin");
            Assert.AreEqual(firstName, false);
        }

        [TestMethod]
        public void WhenGivenFirstName_WithSpecialSymbol_ShouldReturnFalse()
        {
            bool firstName = UserPattern.ValidateFirstAndLastName("#achin");
            Assert.AreEqual(firstName, false);
        }

        [TestMethod]
        public void WhenGivenFirstName_WithNumber_ShouldReturnFalse()
        {
            bool firstName = UserPattern.ValidateFirstAndLastName("123achin");
            Assert.AreEqual(firstName, false);
        }

        [TestMethod]
        public void WhenGivenFirstName_IsLessThanThreeCharacter()
        {
            bool firstName = UserPattern.ValidateFirstAndLastName("Si");
            Assert.AreEqual(firstName, false);
        }

        /// <summary>
        /// Test case for Last Name
        /// </summary>

        [TestMethod]
        public void WhenGivenLastNameStartWithUppercaseReturnTrue()
        {
            bool lastName = UserPattern.ValidateFirstAndLastName("Dabhade");
            Assert.AreEqual(lastName, true);
        }

        [TestMethod]
        public void WhenGivenLastNameStartLowerCaseShouldReturnFalse()
        {
            bool lastName = UserPattern.ValidateFirstAndLastName("dabhade");
            Assert.AreEqual(lastName, false);
        }

        [TestMethod]
        public void WhenGivenLastName_WithSpecialSymbol_ShouldReturnFalse()
        {
            bool lastName = UserPattern.ValidateFirstAndLastName("#dabhade");
            Assert.AreEqual(lastName, false);
        }

        [TestMethod]
        public void WhenGivenLastName_WithNumber_ShouldReturnFalse()
        {
            bool lastName = UserPattern.ValidateFirstAndLastName("123adfdf");
            Assert.AreEqual(lastName, false);
        }

        [TestMethod]
        public void WhenGivenLastName_IsLessThanThreeCharacter()
        {
            bool lastName = UserPattern.ValidateFirstAndLastName("Si");
            Assert.AreEqual(lastName, false);
        }
        /// <summary>
        /// Test Cases for Email validation 
        /// </summary>
        /// Email Validation Valid Scenario
        [TestMethod]
        public void WhenGivenEmail_IfContainsMondatoryParts_ShouldReturnValidEmail()
        {
            bool emailId = UserPattern.ValidateEmailId("abc.100@bl.co.in");
            Assert.AreEqual(emailId, true);
        }

        [TestMethod]
        public void WhenGivenEmail_IfHasOptionalPart_ShouldReturnValidEmail()
        {
            bool emailId = UserPattern.ValidateEmailId("abc@bl.co");
            Assert.AreEqual(emailId, true);
        }

        [TestMethod]
        public void ShouldReturnTrue()
        {
            bool emailId = UserPattern.ValidateEmailId("abc.100@abc.com.au");
            Assert.AreEqual(emailId, true);
        }
        [TestMethod]
        public void WhenItHasTwoDomains()
        {
            bool emailId = UserPattern.ValidateEmailId("abc@gmail.com.com");
            Assert.AreEqual(emailId, true);
        }

        [TestMethod]
        public void WithPlusSign_ShouldReturnTrue()
        {
            bool emailId = UserPattern.ValidateEmailId("abc+100@gmail.com");
            Assert.AreEqual(emailId, true);
        }
        //Email validation Invalid Scenario
        [TestMethod]
        public void WhenGivenEmail_IfInvalid_ShouldReturnInvalidEmail()
        {
            bool emailId = UserPattern.ValidateEmailId("dabhade904@gmail.com.com.in");
            Assert.AreEqual(emailId, false);
        }
        [TestMethod]
        public void MustContainsAtSignSymbol_ShouldReturnFalse()
        {
            bool emailId = UserPattern.ValidateEmailId("abc.100.abc.com.au");
            Assert.AreEqual(emailId, false);
        }
        [TestMethod]
        public void  ShouldNotStartWithDot_ReturnFalse()
        {
            bool emailId = UserPattern.ValidateEmailId("abc@.com.my");
            Assert.AreEqual(emailId, false);
        }

        [TestMethod]
        public void IsNotValidContainsAtLeastTwoCharacters_ShouldReturnFalse()
        {
            bool emailId = UserPattern.ValidateEmailId("abc123@gmail.a");
            Assert.AreEqual(emailId, false);
        }
        [TestMethod]
        public void TldCantStartWithDot()
        {
            bool emailId = UserPattern.ValidateEmailId("abc123@.com");
            Assert.AreEqual(emailId, false);
        }
        [TestMethod]
        public void EmailFirststCharacterCanNotStartWith()
        {
            bool emailId = UserPattern.ValidateEmailId(".abc@abc.com");
            Assert.AreEqual(emailId, false);
        }
        [TestMethod]
        public void EmailIsOnlyAllowCharacterDigitUnderscoreAndDash()
        {
            bool emailId = UserPattern.ValidateEmailId("abc()*@gmail.com");
            Assert.AreEqual(emailId, false);
        }

        [TestMethod]
        public void DoubleDotsAreNotAllow()
        {
            bool emailId = UserPattern.ValidateEmailId("abc..2002@gmail.com");
            Assert.AreEqual(emailId, false);
        }

        [TestMethod]
        public void EmailLastCharacterCanNotEndWithDot()
        {
            bool emailId = UserPattern.ValidateEmailId("abc.@gmail.com");
            Assert.AreEqual(emailId, false);
        }

        [TestMethod]
        public void DoubleAtSignAreNotAllow()
        {
            bool emailId = UserPattern.ValidateEmailId("abc@abc@gmail.com");
            Assert.AreEqual(emailId, false);
        }

        [TestMethod]
        public void CanNotHaveMultipleEmailTld()
        {
            bool emailId = UserPattern.ValidateEmailId("abc@gmail.com.aa.au");
            Assert.AreEqual(emailId, false);
        }
        /// <summary>
        /// Test cases for Mobile validation
        /// </summary>
        [TestMethod]
        public void WhenGivenMobileNumber_WhenProper_ShouldReturnTrue()
        {
            bool mobileNumber = UserPattern.ValidateMobileNumber("91 8888948943");
            Assert.AreEqual(mobileNumber, true);
        }
        [TestMethod]
        public void WhenGivenMobileNumber_WhenNotGivenSpace_ShouldReturnFalse()
        {
            bool mobileNumber = UserPattern.ValidateMobileNumber("9188888948943");
            Assert.AreEqual(mobileNumber, false);
        }

        [TestMethod]
        public void WhenGivenMobileNumber_WhenPassCharacter_ShouldReturnFalse()
        {
            bool mobileNumber = UserPattern.ValidateMobileNumber("abcdefg");
            Assert.AreEqual(mobileNumber, false);
        }

        /// <summary>
        /// Test cases for validate password
        /// </summary>
        [TestMethod]
        public void WhenGivenPassword_IfMinimumEightCharacters_ShouldReturnTrue()
        {
            bool userPassword = UserPattern.ValidatePassword("Pass12@a");
            Assert.AreEqual(userPassword, true);
        }

        [TestMethod]
        public void WhenGivenPassword_WhenSpecialSymbol_ShouldReturnFalse()
        {
            bool userPassword = UserPattern.ValidatePassword("pass@123");
            Assert.AreEqual(userPassword, false);
        }

        [TestMethod]
        public void WhenGivenPassword_IfCharacterLessEight_ShouldReturnFalse()
        {
            bool userPassword = UserPattern.ValidatePassword("pass123");
            Assert.AreEqual(userPassword, false);
        }

        [TestMethod]
        public void WhenGivenPasswordUpper_IfCharacterLessEight_ShouldReturnFalse()
        {
            bool userPassword = UserPattern.ValidatePassword("pass123");
            Assert.AreEqual(userPassword, false);
        }

        [TestMethod]
        public void WhenGivenPassword_IfNoNumericValue_ReturnFalse()
        {
            bool password = UserPattern.ValidatePassword("sachinA");
            Assert.AreEqual(password, false);
        }

        [TestMethod]
        public void ValidatePswd_IfNoSpecialSymbol_ReturnFalse()
        {
            bool password = UserPattern.ValidatePassword("sIchin12");
            Assert.AreEqual(password, false);
        }


    }
}