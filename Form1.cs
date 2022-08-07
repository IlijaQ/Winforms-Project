﻿using System;
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
        {   //container for parameters to be saved
            string[] contents = new string[] { txtBox_serverName.Text, txtBox_DBname.Text, txtBox_user.Text, txtBox_pass.Text, txtBox_parameters.Text  };
            
            //enabling save file dialog in wich user determins where to save file

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; //makes .txt default file format
            string sfdName = saveFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {   //actions that happens if user enters a new file name and clicks "OK"

                File.WriteAllLines(Path.GetFullPath(saveFileDialog1.FileName), contents); //saves file where each array member - parametar is saved in serate line in .txt file
                MessageBox.Show("Project saved");
            }
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //creates a new string array - each line in .txt is an array item
                string[] loadedLines = File.ReadAllLines(openFileDialog1.FileName);

                //populates the following text boxes
                txtBox_serverName.Text = loadedLines[0];
                txtBox_DBname.Text = loadedLines[1];
                txtBox_user.Text = loadedLines[2];
                txtBox_pass.Text = loadedLines[3];

                txtBox_parameters.Text = ""; //erases default tex in parameters text box

                for (int i = 4; i < loadedLines.Length; i++) //adds new line in last textbox for every item from position 4 to the end of the array
                {
                    txtBox_parameters.Text = txtBox_parameters.Text + loadedLines[i] + "\r\n";
                }

                 

            }
            

        }


        ///////////////
        private void txtBox_pass_TextChanged(object sender, EventArgs e)
        {
            lbl_passStrength.Text = CheckPassword(txtBox_pass.Text);
        }

        public static string CheckPassword(string password)
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
