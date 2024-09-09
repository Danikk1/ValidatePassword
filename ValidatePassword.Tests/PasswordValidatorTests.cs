using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidatePassword;

namespace ValidatePassword.Tests
{
    [TestClass]
    public class PasswordValidatorTests
    {
        [TestMethod]
        public void ValidatePassword_AllCriteriaMet_ShouldReturn5()
        {
            string password = "StrongP@ssw0rd";
            PasswordValidator validator = new PasswordValidator();

            int score = validator.ValidatePassword(password);

            Assert.AreEqual(5, score);
        }

        [TestMethod]
        public void ValidatePassword_MissingDigits_ShouldReturn4()
        {
            string password = "StrongP@ssword";
            PasswordValidator validator = new PasswordValidator();

            int score = validator.ValidatePassword(password);

            Assert.AreEqual(4, score);
        }

        [TestMethod]
        public void ValidatePassword_MissingLowercaseLetters_ShouldReturn4()
        {
            string password = "STRONGP@SSW0RD";
            PasswordValidator validator = new PasswordValidator();

            int score = validator.ValidatePassword(password);

            Assert.AreEqual(4, score);
        }

        [TestMethod]
        public void ValidatePassword_MissingUppercaseLetters_ShouldReturn4()
        {
            string password = "strongp@ssw0rd";
            PasswordValidator validator = new PasswordValidator();

            int score = validator.ValidatePassword(password);

            Assert.AreEqual(4, score);
        }

        [TestMethod]
        public void ValidatePassword_MissingSpecialCharacters_ShouldReturn4()
        {
            string password = "StrongPassw0rd";
            PasswordValidator validator = new PasswordValidator();

            int score = validator.ValidatePassword(password);

            Assert.AreEqual(4, score);
        }

        [TestMethod]
        public void ValidatePassword_LessThan10Characters_ShouldReturn0()
        {
            string password = "Short1@";
            PasswordValidator validator = new PasswordValidator();

            int score = validator.ValidatePassword(password);

            Assert.AreEqual(0, score);
        }
    }
}
