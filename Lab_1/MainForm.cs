using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void passwLength_ValueChanged(object sender, EventArgs e)
        {
            if (passwLength.Value < 10)
            {
                sequrityStatus.ForeColor = Color.IndianRed;
                sequrityStatus.Text = "Ненадежный! х";
            }
            else if (passwLength.Value < 14)
            {
                sequrityStatus.ForeColor = Color.DarkOrange;
                sequrityStatus.Text = "Средний";
            }
            else
            {
                sequrityStatus.ForeColor = Color.ForestGreen;
                sequrityStatus.Text = "Надежный ✓";
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {

            Random random = new Random();

            decimal length = passwLength.Value;

            string password = GeneratePassw(length, notSimilarSymb.Checked, specialSymb.Checked, rockyouPassw.Checked);

            passwField.Text = password;

        }

        public string GeneratePassw(decimal length, bool notExcludeSimilar, bool includeSpecial, bool includeRockyou)
        {
            string validChars = "abcdefghjkmnpqrstuvwxyzABCDEFGHJKMNPQRSTUVWXYZ23456789";
            string similarChars1 = "il1L";
            string similarChars2 = "oO0";
            string specialChars = specialCharsBox.Text;

            Random random = new Random();


            /*int randomIndex1 = random.Next(similarChars1.Length - 1); 

            char randomChar1 = similarChars1[randomIndex1]; 

            int randomIndex2 = random.Next(similarChars2.Length - 1); 

            char randomChar2 = similarChars2[randomIndex2]; */

            if (notExcludeSimilar == false)
            {
                validChars += similarChars1 + similarChars2;
            }


            if (includeSpecial)
            {
                validChars += specialChars;
            }

            string password = GenerateRandomPassword(length, validChars);


            if (!includeRockyou)
            {
                return password;
            }
            else
            {
                if (IsPasswUnique(password))
                {
                    return password;
                }
                else
                {
                    while (!IsPasswUnique(password))
                    {
                        password = GenerateRandomPassword(length, validChars);
                    }

                    return password;
                }
            }

        }

        public static string GenerateRandomPassword(decimal length, string chars)
        {
            Random random = new Random();

            StringBuilder password = new StringBuilder();

            for (decimal i = 0; i < length; i++)
            {
                int randomIndex = random.Next(chars.Length);
                char randomChar = chars[randomIndex];
                password.Append(randomChar);
            }

            return password.ToString();
        }

        private bool IsPasswUnique(string password)
        {
            if (File.Exists("rockyou.txt"))
            {
                string[] passws = File.ReadAllLines("rockyou.txt");

                foreach (string passw in passws)
                {
                    if (passw == password)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool IsLoginUnique(string login)
        {
            if (File.Exists("logins.txt"))
            {
                using (StreamReader sr = new StreamReader("logins.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 1 && parts[0] == login)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private void returnAllBtn_Click(object sender, EventArgs e)
        {
            specialCharsBox.Text = "{}[]()/\\'\"`~,:.<>";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string login = loginField.Text;

            string password = passwField.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || password == "Пароль" || login == "Логин")
            {
                MessageBox.Show("Поля логина и пароля пустые, проверьте введенные данные и попробуйте заново", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!IsLoginUnique(login))
            {
                MessageBox.Show("Логин уже существует. Пожалуйста, выберите другой логин.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (StreamWriter sw = new StreamWriter("logins.txt", true))
            {
                sw.WriteLine(login + "," + password);
                MessageBox.Show("Логин и пароль успешно сохранены.", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            loginField.Text = string.Empty;
            loginField.ForeColor = Color.Black;
        }
    }
}
