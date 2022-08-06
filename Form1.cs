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
    }
}
