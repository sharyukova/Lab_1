using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class MainFormPublic
    {
        public bool IsLoginUnique(string login)
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

        public bool IsPasswUnique(string password)
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
    }
}
