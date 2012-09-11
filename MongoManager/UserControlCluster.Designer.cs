namespace MongoManager
{
    partial class UserControlCluster
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
            this.textBoxClusterName = new System.Windows.Forms.TextBox();
            this.labelClusterName = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxClusterName
            // 
            this.textBoxClusterName.Location = new System.Drawing.Point(65, 25);
            this.textBoxClusterName.Name = "textBoxClusterName";
            this.textBoxClusterName.Size = new System.Drawing.Size(175, 20);
            this.textBoxClusterName.TabIndex = 13;
            // 
            // labelClusterName
            // 
            this.labelClusterName.AutoSize = true;
            this.labelClusterName.Location = new System.Drawing.Point(21, 28);
            this.labelClusterName.Name = "labelClusterName";
            this.labelClusterName.Size = new System.Drawing.Size(38, 13);
            this.labelClusterName.TabIndex = 12;
            this.labelClusterName.Text = "Name:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(165, 62);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // UserControlCluster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxClusterName);
            this.Controls.Add(this.labelClusterName);
            this.Name = "UserControlCluster";
            this.Size = new System.Drawing.Size(530, 362);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClusterName;
        private System.Windows.Forms.Label labelClusterName;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
