using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Project
    {
        //Properties
        public string ServerName { get; set; }
        public string DbName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Parameters { get; set; }

        //Constructor
        public Project()
        {
            Parameters = $"Creation date: {DateTime.Now.ToString("dd.MM.yyyy")}\r\nClient Company: Example inc\r\nTarget finish date:";

        }

        //Methods
        public string CheckPassword(string password)
        {
            //checks if password has upper/lowercase, number, symbol and at least 8 characters
            //grants strength point for each condition met

            int strength = 0;

            if (password.Any(c => char.IsNumber(c)))
            {
                strength++;
            }
            if (password.Any(c => char.IsUpper(c)))
            {
                strength++;
            }
            if (password.Any(c => char.IsLower(c)))
            {
                strength++;
            }
            if (password.Any(c => !char.IsLetter(c) && !char.IsNumber(c))) //determens wheader password has symbol(s) if particular character isnt a letter nor a number
            {
                strength++;
            }
            if (password.Length > 7)
            {
                strength++;
            }
            if ((password == "pass") || (password == "password") || (password == "12345"))
            {               //ultra weak passwords, grants 0 strength points immediatly
                strength = 0;
            }

            switch (strength)
            {   //suggestive messages for user, depending on current password strength
                case 0: return "your password is poor"; break;
                case 1: return "your password is bad strength"; break;
                case 2: return "your password is low strength"; break;
                case 3: return "your password is medium strength"; break;
                case 4: return "your password is strong"; break;
                case 5: return "your password is very strong"; break;
                default: return ""; break;
            }

        }

    }
}
