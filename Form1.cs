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

            SetDefaultValues();



        }

        string openedFilePath;

        private void btn_saveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            //container for parameters to be saved
            string[] contents = new string[] { txtBox_serverName.Text, txtBox_DBname.Text, txtBox_user.Text, txtBox_pass.Text, txtBox_parameters.Text };
            

            //enabling save file dialog in wich user determins where to save file

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; //makes .txt default file format
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {   //actions that happens if user enters a new file name and clicks "OK"

                File.WriteAllLines(Path.GetFullPath(saveFileDialog1.FileName), contents); //saves file where each array member - parametar is saved in serate line in .txt file
                openedFilePath = Path.GetFullPath(saveFileDialog1.FileName);

                AddCurrentProjToRecentList();

                MessageBox.Show("Project saved");
            }

        }

        private void AddCurrentProjToRecentList()
        {
            string[] recentFilesList = File.ReadAllLines("recentFilesLog.txt");

            for (int i = (int)numBox_numOfResentProjects.Value - 2; i >= 0 ; i--)
            {
                recentFilesList[i + 1] = recentFilesList[i];
            }
            recentFilesList[0] = openedFilePath;

            File.WriteAllLines("recentFilesLog.txt", recentFilesList);

            listBox_recentProj.Items.Clear();
            listBox_recentProj.Items.AddRange(recentFilesList);
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //remembers file location to be available for "save" button - save changes
                openedFilePath = Path.GetFullPath(openFileDialog1.FileName);

                //creates a new string array - each line in .txt is an array item
                string[] loadedLines = File.ReadAllLines(openFileDialog1.FileName);

                PopulateUiFromLoadeFile(loadedLines);

                AddCurrentProjToRecentList();

            }
        }

        private void PopulateUiFromLoadeFile(string[] loadedLines)
        {
            //populates the following text boxes
            txtBox_serverName.Text = loadedLines[0];
            txtBox_DBname.Text = loadedLines[1];
            txtBox_user.Text = loadedLines[2];
            txtBox_pass.Text = loadedLines[3];

            txtBox_parameters.Text = ""; //erases default text in parameters text box

            for (int i = 4; i < loadedLines.Length; i++) //adds new line in last textbox for every item from position 4 to the end of the array
            {

                txtBox_parameters.Text = txtBox_parameters.Text + loadedLines[i];
                if (i < loadedLines.Length - 1) //prevents adding an empty line at the end of textbox content
                {
                    txtBox_parameters.Text = txtBox_parameters.Text + "\r\n";
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(openedFilePath))
            {
                string[] contents = new string[] { txtBox_serverName.Text, txtBox_DBname.Text, txtBox_user.Text, txtBox_pass.Text, txtBox_parameters.Text };
                File.WriteAllLines(openedFilePath, contents);
                MessageBox.Show("Changes saved");
            }
            else
            {
                SaveAs();
            }


        }

        #region Password strength
        private void txtBox_pass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_pass.Text))
            {
                lbl_passStrength.Text = "";
            }
            else
            {
                lbl_passStrength.Text = CheckPassword(txtBox_pass.Text);

                //Changes the color of the suggestive password strength label accordingly
                if(lbl_passStrength.Text.Contains("poor") || lbl_passStrength.Text.Contains("bad") || lbl_passStrength.Text.Contains("low"))
                {
                    lbl_passStrength.ForeColor = Color.Red;
                }
                if (lbl_passStrength.Text.Contains("medium"))
                {
                    lbl_passStrength.ForeColor = Color.Black;
                }
                if (lbl_passStrength.Text.Contains("strong"))
                {
                    lbl_passStrength.ForeColor = Color.Green;
                }
            }
            
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
                case 0: return "your password is poor strength";
                case 1: return "your password is bad strength";
                case 2: return "your password is low strength";
                case 3: return "your password is medium strength";
                case 4: return "your password is strong";
                case 5: return "your password is very strong";
                default: return "";
            }

        }
        #endregion

        private void btn_CreateNewFile_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            string[] loadedLines = File.ReadAllLines("DefaultValues.txt");
            PopulateUiFromLoadeFile(loadedLines);
        }

        private void btn_setDefaultVal_Click(object sender, EventArgs e)
        {
            string[] contents = new string[] { txtBox_serverName.Text, txtBox_DBname.Text, txtBox_user.Text, txtBox_pass.Text, txtBox_parameters.Text };
            File.WriteAllLines("DefaultValues.txt", contents); //saves deault values
            
            MessageBox.Show("Default values set");
        }

        private void numBox_numOfResentProjects_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_showResent_Click(object sender, EventArgs e)
        {

        }
    }

    
}
