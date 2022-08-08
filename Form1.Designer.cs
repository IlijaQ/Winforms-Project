
namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CreateNewFile = new System.Windows.Forms.Button();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_showResent = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_saveAs = new System.Windows.Forms.Button();
            this.lbl_descriptiveLabel_serverName = new System.Windows.Forms.Label();
            this.lbl_descriptiveLabel_DBname = new System.Windows.Forms.Label();
            this.lbl_descriptiveLabel_user = new System.Windows.Forms.Label();
            this.lbl_descriptiveLabel_pass = new System.Windows.Forms.Label();
            this.lbl_descriptiveLabel_parameters = new System.Windows.Forms.Label();
            this.txtBox_serverName = new System.Windows.Forms.TextBox();
            this.txtBox_DBname = new System.Windows.Forms.TextBox();
            this.txtBox_user = new System.Windows.Forms.TextBox();
            this.txtBox_pass = new System.Windows.Forms.TextBox();
            this.txtBox_parameters = new System.Windows.Forms.TextBox();
            this.lbl_passStrength = new System.Windows.Forms.Label();
            this.btn_setDefaultVal = new System.Windows.Forms.Button();
            this.numBox_numOfResentProjects = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_recentProj = new System.Windows.Forms.ListBox();
            this.lbl_descriptiveLabel_resent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_numOfResentProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CreateNewFile
            // 
            this.btn_CreateNewFile.Location = new System.Drawing.Point(16, 15);
            this.btn_CreateNewFile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CreateNewFile.Name = "btn_CreateNewFile";
            this.btn_CreateNewFile.Size = new System.Drawing.Size(100, 28);
            this.btn_CreateNewFile.TabIndex = 0;
            this.btn_CreateNewFile.Text = "new";
            this.btn_CreateNewFile.UseVisualStyleBackColor = true;
            this.btn_CreateNewFile.Click += new System.EventHandler(this.btn_CreateNewFile_Click);
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(124, 15);
            this.btn_openFile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(100, 28);
            this.btn_openFile.TabIndex = 1;
            this.btn_openFile.Text = "open";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // btn_showResent
            // 
            this.btn_showResent.Location = new System.Drawing.Point(232, 453);
            this.btn_showResent.Margin = new System.Windows.Forms.Padding(4);
            this.btn_showResent.Name = "btn_showResent";
            this.btn_showResent.Size = new System.Drawing.Size(220, 28);
            this.btn_showResent.TabIndex = 2;
            this.btn_showResent.Text = "Open selected recent project";
            this.btn_showResent.UseVisualStyleBackColor = true;
            this.btn_showResent.Click += new System.EventHandler(this.btn_showResent_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(232, 15);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 28);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_saveAs
            // 
            this.btn_saveAs.Location = new System.Drawing.Point(340, 15);
            this.btn_saveAs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_saveAs.Name = "btn_saveAs";
            this.btn_saveAs.Size = new System.Drawing.Size(100, 28);
            this.btn_saveAs.TabIndex = 4;
            this.btn_saveAs.Text = "save as";
            this.btn_saveAs.UseVisualStyleBackColor = true;
            this.btn_saveAs.Click += new System.EventHandler(this.btn_saveAs_Click);
            // 
            // lbl_descriptiveLabel_serverName
            // 
            this.lbl_descriptiveLabel_serverName.AutoSize = true;
            this.lbl_descriptiveLabel_serverName.Location = new System.Drawing.Point(597, 143);
            this.lbl_descriptiveLabel_serverName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descriptiveLabel_serverName.Name = "lbl_descriptiveLabel_serverName";
            this.lbl_descriptiveLabel_serverName.Size = new System.Drawing.Size(89, 17);
            this.lbl_descriptiveLabel_serverName.TabIndex = 5;
            this.lbl_descriptiveLabel_serverName.Text = "Server name";
            // 
            // lbl_descriptiveLabel_DBname
            // 
            this.lbl_descriptiveLabel_DBname.AutoSize = true;
            this.lbl_descriptiveLabel_DBname.Location = new System.Drawing.Point(597, 180);
            this.lbl_descriptiveLabel_DBname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descriptiveLabel_DBname.Name = "lbl_descriptiveLabel_DBname";
            this.lbl_descriptiveLabel_DBname.Size = new System.Drawing.Size(108, 17);
            this.lbl_descriptiveLabel_DBname.TabIndex = 6;
            this.lbl_descriptiveLabel_DBname.Text = "Database name";
            // 
            // lbl_descriptiveLabel_user
            // 
            this.lbl_descriptiveLabel_user.AutoSize = true;
            this.lbl_descriptiveLabel_user.Location = new System.Drawing.Point(597, 219);
            this.lbl_descriptiveLabel_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descriptiveLabel_user.Name = "lbl_descriptiveLabel_user";
            this.lbl_descriptiveLabel_user.Size = new System.Drawing.Size(73, 17);
            this.lbl_descriptiveLabel_user.TabIndex = 7;
            this.lbl_descriptiveLabel_user.Text = "Username";
            // 
            // lbl_descriptiveLabel_pass
            // 
            this.lbl_descriptiveLabel_pass.AutoSize = true;
            this.lbl_descriptiveLabel_pass.Location = new System.Drawing.Point(597, 260);
            this.lbl_descriptiveLabel_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descriptiveLabel_pass.Name = "lbl_descriptiveLabel_pass";
            this.lbl_descriptiveLabel_pass.Size = new System.Drawing.Size(69, 17);
            this.lbl_descriptiveLabel_pass.TabIndex = 8;
            this.lbl_descriptiveLabel_pass.Text = "Password";
            // 
            // lbl_descriptiveLabel_parameters
            // 
            this.lbl_descriptiveLabel_parameters.AutoSize = true;
            this.lbl_descriptiveLabel_parameters.Location = new System.Drawing.Point(597, 298);
            this.lbl_descriptiveLabel_parameters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descriptiveLabel_parameters.Name = "lbl_descriptiveLabel_parameters";
            this.lbl_descriptiveLabel_parameters.Size = new System.Drawing.Size(81, 17);
            this.lbl_descriptiveLabel_parameters.TabIndex = 9;
            this.lbl_descriptiveLabel_parameters.Text = "Parameters";
            // 
            // txtBox_serverName
            // 
            this.txtBox_serverName.Location = new System.Drawing.Point(725, 139);
            this.txtBox_serverName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_serverName.Name = "txtBox_serverName";
            this.txtBox_serverName.Size = new System.Drawing.Size(292, 22);
            this.txtBox_serverName.TabIndex = 10;
            // 
            // txtBox_DBname
            // 
            this.txtBox_DBname.Location = new System.Drawing.Point(725, 176);
            this.txtBox_DBname.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_DBname.Name = "txtBox_DBname";
            this.txtBox_DBname.Size = new System.Drawing.Size(292, 22);
            this.txtBox_DBname.TabIndex = 11;
            // 
            // txtBox_user
            // 
            this.txtBox_user.Location = new System.Drawing.Point(725, 215);
            this.txtBox_user.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_user.Name = "txtBox_user";
            this.txtBox_user.Size = new System.Drawing.Size(292, 22);
            this.txtBox_user.TabIndex = 12;
            // 
            // txtBox_pass
            // 
            this.txtBox_pass.Location = new System.Drawing.Point(725, 256);
            this.txtBox_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_pass.Name = "txtBox_pass";
            this.txtBox_pass.Size = new System.Drawing.Size(292, 22);
            this.txtBox_pass.TabIndex = 13;
            this.txtBox_pass.TextChanged += new System.EventHandler(this.txtBox_pass_TextChanged);
            // 
            // txtBox_parameters
            // 
            this.txtBox_parameters.Location = new System.Drawing.Point(725, 298);
            this.txtBox_parameters.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_parameters.Multiline = true;
            this.txtBox_parameters.Name = "txtBox_parameters";
            this.txtBox_parameters.Size = new System.Drawing.Size(292, 138);
            this.txtBox_parameters.TabIndex = 14;
            // 
            // lbl_passStrength
            // 
            this.lbl_passStrength.AutoSize = true;
            this.lbl_passStrength.Location = new System.Drawing.Point(1034, 260);
            this.lbl_passStrength.Name = "lbl_passStrength";
            this.lbl_passStrength.Size = new System.Drawing.Size(0, 17);
            this.lbl_passStrength.TabIndex = 15;
            // 
            // btn_setDefaultVal
            // 
            this.btn_setDefaultVal.Location = new System.Drawing.Point(447, 15);
            this.btn_setDefaultVal.Name = "btn_setDefaultVal";
            this.btn_setDefaultVal.Size = new System.Drawing.Size(150, 28);
            this.btn_setDefaultVal.TabIndex = 16;
            this.btn_setDefaultVal.Text = "set default values";
            this.btn_setDefaultVal.UseVisualStyleBackColor = true;
            this.btn_setDefaultVal.Click += new System.EventHandler(this.btn_setDefaultVal_Click);
            // 
            // numBox_numOfResentProjects
            // 
            this.numBox_numOfResentProjects.Location = new System.Drawing.Point(352, 98);
            this.numBox_numOfResentProjects.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBox_numOfResentProjects.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numBox_numOfResentProjects.Name = "numBox_numOfResentProjects";
            this.numBox_numOfResentProjects.Size = new System.Drawing.Size(100, 22);
            this.numBox_numOfResentProjects.TabIndex = 17;
            this.numBox_numOfResentProjects.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBox_numOfResentProjects.ValueChanged += new System.EventHandler(this.numBox_numOfResentProjects_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "number of recent\r\nprojects to show";
            // 
            // listBox_recentProj
            // 
            this.listBox_recentProj.FormattingEnabled = true;
            this.listBox_recentProj.ItemHeight = 16;
            this.listBox_recentProj.Location = new System.Drawing.Point(232, 176);
            this.listBox_recentProj.Name = "listBox_recentProj";
            this.listBox_recentProj.Size = new System.Drawing.Size(220, 260);
            this.listBox_recentProj.TabIndex = 19;
            // 
            // lbl_descriptiveLabel_resent
            // 
            this.lbl_descriptiveLabel_resent.AutoSize = true;
            this.lbl_descriptiveLabel_resent.Location = new System.Drawing.Point(232, 143);
            this.lbl_descriptiveLabel_resent.Name = "lbl_descriptiveLabel_resent";
            this.lbl_descriptiveLabel_resent.Size = new System.Drawing.Size(135, 21);
            this.lbl_descriptiveLabel_resent.TabIndex = 20;
            this.lbl_descriptiveLabel_resent.Text = "Recent Projects";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 431);
            this.Controls.Add(this.lbl_descriptiveLabel_resent);
            this.Controls.Add(this.listBox_recentProj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBox_numOfResentProjects);
            this.Controls.Add(this.btn_setDefaultVal);
            this.Controls.Add(this.lbl_passStrength);
            this.Controls.Add(this.txtBox_parameters);
            this.Controls.Add(this.txtBox_pass);
            this.Controls.Add(this.txtBox_user);
            this.Controls.Add(this.txtBox_DBname);
            this.Controls.Add(this.txtBox_serverName);
            this.Controls.Add(this.lbl_descriptiveLabel_parameters);
            this.Controls.Add(this.lbl_descriptiveLabel_pass);
            this.Controls.Add(this.lbl_descriptiveLabel_user);
            this.Controls.Add(this.lbl_descriptiveLabel_DBname);
            this.Controls.Add(this.lbl_descriptiveLabel_serverName);
            this.Controls.Add(this.btn_saveAs);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_showResent);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.btn_CreateNewFile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numBox_numOfResentProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateNewFile;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Button btn_showResent;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_saveAs;
        private System.Windows.Forms.Label lbl_descriptiveLabel_serverName;
        private System.Windows.Forms.Label lbl_descriptiveLabel_DBname;
        private System.Windows.Forms.Label lbl_descriptiveLabel_user;
        private System.Windows.Forms.Label lbl_descriptiveLabel_pass;
        private System.Windows.Forms.Label lbl_descriptiveLabel_parameters;
        private System.Windows.Forms.TextBox txtBox_serverName;
        private System.Windows.Forms.TextBox txtBox_DBname;
        private System.Windows.Forms.TextBox txtBox_user;
        private System.Windows.Forms.TextBox txtBox_pass;
        private System.Windows.Forms.TextBox txtBox_parameters;
        private System.Windows.Forms.Label lbl_passStrength;
        private System.Windows.Forms.Button btn_setDefaultVal;
        private System.Windows.Forms.NumericUpDown numBox_numOfResentProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_recentProj;
        private System.Windows.Forms.Label lbl_descriptiveLabel_resent;
    }
}

