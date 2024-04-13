using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace Lab_1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] //1
        public void GeneratePassw_Length_ReturnsInsecurePassword()
        {
            decimal length = 9;

            MainForm form = new MainForm();
            string password = form.GeneratePassw(length, true, false, false);

            Assert.AreEqual(9, password.Length);
        }

        [TestMethod] //2
        public void IsLoginUnique_ExistingLogin_ReturnsFalse()
        {
            MainFormPublic form = new MainFormPublic();
            string login = "existing_login";
            File.WriteAllText("logins.txt", "existing_login,password");
            bool result = form.IsLoginUnique(login);
            Assert.IsFalse(result);
        }

        [TestMethod] //3
        public void IsLoginUnique_NonExistingLogin_ReturnsTrue()
        {
            MainFormPublic form = new MainFormPublic();
            string login = "new_login";
            File.WriteAllText("logins.txt", "existing_login,password");
            bool result = form.IsLoginUnique(login);
            Assert.IsTrue(result);
        }

        [TestMethod] //4
        public void IsPasswUnique_ExistingPasswordInRockyou_ReturnsFalse()
        {
            MainFormPublic form = new MainFormPublic();
            string password = "password123";
            File.WriteAllText("rockyou.txt", "password123");
            bool result = form.IsPasswUnique(password);
            Assert.IsFalse(result);
        }

        [TestMethod] //5
        public void IsPasswUnique_NonExistingPasswordInRockyou_ReturnsTrue()
        {
            MainFormPublic form = new MainFormPublic();
            string password = "newpassword123";
            File.WriteAllText("rockyou.txt", "password123");
            bool result = form.IsPasswUnique(password);
            Assert.IsTrue(result);
        }

        [TestMethod] //6
        public void GeneratePassw_ExcludesSimilarCharacters_WhenNotExcludeSimilarIsTrue()
        {
            MainForm form = new MainForm();

            string password = form.GeneratePassw(35, true, false, false);

            Assert.IsFalse(password.Contains("I")); // Проверяем, что пароль не содержит похожий символ "I"
            Assert.IsFalse(password.Contains("i"));
            Assert.IsFalse(password.Contains("1"));
            Assert.IsFalse(password.Contains("l"));
            Assert.IsFalse(password.Contains("L"));
            Assert.IsFalse(password.Contains("0"));
            Assert.IsFalse(password.Contains("o"));
            Assert.IsFalse(password.Contains("O"));
        }

        [TestMethod] //7
        public void GeneratePassw_IncludesSpecialCharacters_WhenIncludeSpecialIsTrue()
        {
            MainForm form = new MainForm();

            string password = form.GeneratePassw(55, false, true, false);

            Assert.IsTrue(password.Any(char.IsSymbol)); // Проверяем, что пароль содержит хотя бы один специальный символ
        }

        [TestMethod] //8
        public void GenerateRandomPassword_ReturnsPasswordWithCorrectLength()
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int length = 10;
            string password;

            password = MainForm.GenerateRandomPassword(length, chars);

            Assert.AreEqual(length, password.Length); // Проверяем, что длина сгенерированного пароля соответствует заданной длине
        }

        [TestMethod] //9
        public void GenerateRandomPassword_ReturnsPasswordWithValidCharacters()
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int length = 10;

            string password = MainForm.GenerateRandomPassword(length, chars);

            foreach (char c in password)
            {
                Assert.IsTrue(chars.Contains(c.ToString())); // Проверяем, что все символы в пароле принадлежат к набору символов chars
            }
        }
    }
}
