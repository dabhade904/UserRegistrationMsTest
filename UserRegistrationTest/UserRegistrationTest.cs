using System;
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
        public void whenGivenFirstName_WithSpecialSymbol_ShouldReturnFalse()
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
        public void whenGivenLastName_WithSpecialSymbol_ShouldReturnFalse()
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

        [TestMethod]
        public void whenGivenEmail_IfContainsMondatoryParts_ShouldReturnValidEmail()
        {
            bool emailId = UserPattern.ValidateEmailId("abc.xyz@bl.co.in");
            Assert.AreEqual(emailId,true);
        }

        [TestMethod]
        public void whenGivenEmail_IfHasOptionalPart_ShouldReturnValidEmail()
        {
            bool emailId = UserPattern.ValidateEmailId("abc@bl.co");
            Assert.AreEqual(emailId,true);
        }

        [TestMethod]
        public void whenGivenEmail_IfInvalid_ShouldReturnInvalidEmail()
        {
            bool emailId = UserPattern.ValidateEmailId("dabhade904@gmail.com.com.in");
            Assert.AreEqual(emailId,false);
        }

    }
}