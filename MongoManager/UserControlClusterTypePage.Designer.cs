namespace MongoManager
{
    partial class UserControlClusterTypePage
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
            this.checkBoxReplSet = new System.Windows.Forms.CheckBox();
            this.checkBoxSharding = new System.Windows.Forms.CheckBox();
            this.numericUpDownReplSetInstance = new System.Windows.Forms.NumericUpDown();
            this.labelReplSetNumber = new System.Windows.Forms.Label();
            this.labelShardInstance = new System.Windows.Forms.Label();
            this.numericUpDownShardInstance = new System.Windows.Forms.NumericUpDown();
            this.labelMongosInstance = new System.Windows.Forms.Label();
            this.numericUpDownMongosInstance = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMongoConfigInstance = new System.Windows.Forms.ComboBox();
            this.labelMongoConfigInstance = new System.Windows.Forms.Label();
            this.labelClusterName = new System.Windows.Forms.Label();
            this.textBoxClusterName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReplSetInstance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShardInstance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMongosInstance)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxReplSet
            // 
            this.checkBoxReplSet.AutoSize = true;
            this.checkBoxReplSet.Location = new System.Drawing.Point(23, 47);
            this.checkBoxReplSet.Name = "checkBoxReplSet";
            this.checkBoxReplSet.Size = new System.Drawing.Size(87, 17);
            this.checkBoxReplSet.TabIndex = 1;
            this.checkBoxReplSet.Text = "Replicat Set:";
            this.checkBoxReplSet.UseVisualStyleBackColor = true;
            // 
            // checkBoxSharding
            // 
            this.checkBoxSharding.AutoSize = true;
            this.checkBoxSharding.Location = new System.Drawing.Point(23, 142);
            this.checkBoxSharding.Name = "checkBoxSharding";
            this.checkBoxSharding.Size = new System.Drawing.Size(71, 17);
            this.checkBoxSharding.TabIndex = 2;
            this.checkBoxSharding.Text = "Sharding:";
            this.checkBoxSharding.UseVisualStyleBackColor = true;
            // 
            // numericUpDownReplSetInstance
            // 
            this.numericUpDownReplSetInstance.Location = new System.Drawing.Point(166, 80);
            this.numericUpDownReplSetInstance.Name = "numericUpDownReplSetInstance";
            this.numericUpDownReplSetInstance.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownReplSetInstance.TabIndex = 3;
            this.numericUpDownReplSetInstance.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelReplSetNumber
            // 
            this.labelReplSetNumber.AutoSize = true;
            this.labelReplSetNumber.Location = new System.Drawing.Point(46, 82);
            this.labelReplSetNumber.Name = "labelReplSetNumber";
            this.labelReplSetNumber.Size = new System.Drawing.Size(89, 13);
            this.labelReplSetNumber.TabIndex = 4;
            this.labelReplSetNumber.Text = "Instance number:";
            // 
            // labelShardInstance
            // 
            this.labelShardInstance.AutoSize = true;
            this.labelShardInstance.Location = new System.Drawing.Point(46, 177);
            this.labelShardInstance.Name = "labelShardInstance";
            this.labelShardInstance.Size = new System.Drawing.Size(89, 13);
            this.labelShardInstance.TabIndex = 6;
            this.labelShardInstance.Text = "Instance number:";
            // 
            // numericUpDownShardInstance
            // 
            this.numericUpDownShardInstance.Location = new System.Drawing.Point(166, 175);
            this.numericUpDownShardInstance.Name = "numericUpDownShardInstance";
            this.numericUpDownShardInstance.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownShardInstance.TabIndex = 5;
            this.numericUpDownShardInstance.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelMongosInstance
            // 
            this.labelMongosInstance.AutoSize = true;
            this.labelMongosInstance.Location = new System.Drawing.Point(46, 203);
            this.labelMongosInstance.Name = "labelMongosInstance";
            this.labelMongosInstance.Size = new System.Drawing.Size(86, 13);
            this.labelMongosInstance.TabIndex = 8;
            this.labelMongosInstance.Text = "Mongos number:";
            // 
            // numericUpDownMongosInstance
            // 
            this.numericUpDownMongosInstance.Location = new System.Drawing.Point(166, 201);
            this.numericUpDownMongosInstance.Name = "numericUpDownMongosInstance";
            this.numericUpDownMongosInstance.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownMongosInstance.TabIndex = 7;
            this.numericUpDownMongosInstance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxMongoConfigInstance
            // 
            this.comboBoxMongoConfigInstance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMongoConfigInstance.FormattingEnabled = true;
            this.comboBoxMongoConfigInstance.Items.AddRange(new object[] {
            "1",
            "3"});
            this.comboBoxMongoConfigInstance.Location = new System.Drawing.Point(166, 227);
            this.comboBoxMongoConfigInstance.Name = "comboBoxMongoConfigInstance";
            this.comboBoxMongoConfigInstance.Size = new System.Drawing.Size(73, 21);
            this.comboBoxMongoConfigInstance.TabIndex = 9;
            // 
            // labelMongoConfigInstance
            // 
            this.labelMongoConfigInstance.AutoSize = true;
            this.labelMongoConfigInstance.Location = new System.Drawing.Point(46, 230);
            this.labelMongoConfigInstance.Name = "labelMongoConfigInstance";
            this.labelMongoConfigInstance.Size = new System.Drawing.Size(111, 13);
            this.labelMongoConfigInstance.TabIndex = 8;
            this.labelMongoConfigInstance.Text = "MongoConfig number:";
            // 
            // labelClusterName
            // 
            this.labelClusterName.AutoSize = true;
            this.labelClusterName.Location = new System.Drawing.Point(20, 16);
            this.labelClusterName.Name = "labelClusterName";
            this.labelClusterName.Size = new System.Drawing.Size(38, 13);
            this.labelClusterName.TabIndex = 10;
            this.labelClusterName.Text = "Name:";
            // 
            // textBoxClusterName
            // 
            this.textBoxClusterName.Location = new System.Drawing.Point(64, 13);
            this.textBoxClusterName.Name = "textBoxClusterName";
            this.textBoxClusterName.Size = new System.Drawing.Size(175, 20);
            this.textBoxClusterName.TabIndex = 11;
            // 
            // UserControlClusterTypePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxClusterName);
            this.Controls.Add(this.labelClusterName);
            this.Controls.Add(this.comboBoxMongoConfigInstance);
            this.Controls.Add(this.labelMongoConfigInstance);
            this.Controls.Add(this.labelMongosInstance);
            this.Controls.Add(this.numericUpDownMongosInstance);
            this.Controls.Add(this.labelShardInstance);
            this.Controls.Add(this.numericUpDownShardInstance);
            this.Controls.Add(this.labelReplSetNumber);
            this.Controls.Add(this.numericUpDownReplSetInstance);
            this.Controls.Add(this.checkBoxSharding);
            this.Controls.Add(this.checkBoxReplSet);
            this.Name = "UserControlClusterTypePage";
            this.Size = new System.Drawing.Size(320, 299);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReplSetInstance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShardInstance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMongosInstance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxReplSet;
        private System.Windows.Forms.CheckBox checkBoxSharding;
        private System.Windows.Forms.NumericUpDown numericUpDownReplSetInstance;
        private System.Windows.Forms.Label labelReplSetNumber;
        private System.Windows.Forms.Label labelShardInstance;
        private System.Windows.Forms.NumericUpDown numericUpDownShardInstance;
        private System.Windows.Forms.Label labelMongosInstance;
        private System.Windows.Forms.NumericUpDown numericUpDownMongosInstance;
        private System.Windows.Forms.ComboBox comboBoxMongoConfigInstance;
        private System.Windows.Forms.Label labelMongoConfigInstance;
        private System.Windows.Forms.Label labelClusterName;
        private System.Windows.Forms.TextBox textBoxClusterName;
    }
}
