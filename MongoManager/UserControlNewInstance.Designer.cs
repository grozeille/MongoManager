namespace MongoManager
{
    partial class UserControlNewInstance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInstanceName = new System.Windows.Forms.TextBox();
            this.comboBoxServer = new System.Windows.Forms.ComboBox();
            this.comboBoxServiceAccount = new System.Windows.Forms.ComboBox();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxStartupType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInstanceName
            // 
            this.textBoxInstanceName.Location = new System.Drawing.Point(10, 10);
            this.textBoxInstanceName.Name = "textBoxInstanceName";
            this.textBoxInstanceName.Size = new System.Drawing.Size(157, 20);
            this.textBoxInstanceName.TabIndex = 0;
            this.textBoxInstanceName.Text = "mongos_1";
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Location = new System.Drawing.Point(173, 10);
            this.comboBoxServer.Name = "comboBoxServer";
            this.comboBoxServer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxServer.TabIndex = 1;
            // 
            // comboBoxServiceAccount
            // 
            this.comboBoxServiceAccount.AutoCompleteCustomSource.AddRange(new string[] {
            "Local System",
            "Local Service",
            "Network Service",
            "User"});
            this.comboBoxServiceAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServiceAccount.FormattingEnabled = true;
            this.comboBoxServiceAccount.Location = new System.Drawing.Point(411, 10);
            this.comboBoxServiceAccount.Name = "comboBoxServiceAccount";
            this.comboBoxServiceAccount.Size = new System.Drawing.Size(121, 21);
            this.comboBoxServiceAccount.TabIndex = 2;
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(300, 11);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownPort.TabIndex = 3;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(538, 10);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(121, 20);
            this.textBoxLogin.TabIndex = 4;
            // 
            // maskedTextBoxPassword
            // 
            this.maskedTextBoxPassword.Location = new System.Drawing.Point(665, 10);
            this.maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            this.maskedTextBoxPassword.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxPassword.TabIndex = 5;
            this.maskedTextBoxPassword.UseSystemPasswordChar = true;
            // 
            // comboBoxStartupType
            // 
            this.comboBoxStartupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartupType.FormattingEnabled = true;
            this.comboBoxStartupType.Items.AddRange(new object[] {
            "Automatic",
            "Manual",
            "Disable"});
            this.comboBoxStartupType.Location = new System.Drawing.Point(792, 10);
            this.comboBoxStartupType.Name = "comboBoxStartupType";
            this.comboBoxStartupType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStartupType.TabIndex = 6;
            // 
            // UserControlInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxStartupType);
            this.Controls.Add(this.maskedTextBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.numericUpDownPort);
            this.Controls.Add(this.comboBoxServiceAccount);
            this.Controls.Add(this.comboBoxServer);
            this.Controls.Add(this.textBoxInstanceName);
            this.Name = "UserControlInstance";
            this.Size = new System.Drawing.Size(920, 42);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInstanceName;
        private System.Windows.Forms.ComboBox comboBoxServer;
        private System.Windows.Forms.ComboBox comboBoxServiceAccount;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxStartupType;
    }
}
