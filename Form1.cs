using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_saveAs_Click(object sender, EventArgs e)
        {
            string[] contents = new string[] { txtBox_serverName.Text, txtBox_DBname.Text, txtBox_user.Text, txtBox_pass.Text, txtBox_parameters.Text  };

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            string sfdName = saveFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllLines(Path.GetFullPath(saveFileDialog1.FileName), contents);
            }
        }

        private void txtBox_pass_TextChanged(object sender, EventArgs e)
        {
            lbl_passStrength.Text = CheckPassword(txtBox_pass.Text);
        }

        public static string CheckPassword(string password)
        {

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
            if (password.Any(c => !char.IsLetter(c) && !char.IsNumber(c)))
            {
                strength++;
            }
            if (password.Length > 7)
            {
                strength++;
            }
            if ((password == "pass") || (password == "password") || (password == "12345"))
            {
                strength = 0;
            }

            switch (strength)
            {
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
