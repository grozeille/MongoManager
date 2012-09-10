namespace MongoManager
{
    partial class AddClusterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClusterForm));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.userControlClusterTypePage = new MongoManager.UserControlClusterTypePage();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(372, 11);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinish.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonFinish.Location = new System.Drawing.Point(281, 11);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(85, 23);
            this.buttonFinish.TabIndex = 10;
            this.buttonFinish.Text = "&Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonNext.Location = new System.Drawing.Point(190, 11);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(85, 23);
            this.buttonNext.TabIndex = 11;
            this.buttonNext.Text = "&Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBack.Location = new System.Drawing.Point(99, 11);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(85, 23);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "&Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelSeparator
            // 
            this.labelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSeparator.Location = new System.Drawing.Point(0, 0);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(469, 2);
            this.labelSeparator.TabIndex = 13;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.buttonBack);
            this.panelFooter.Controls.Add(this.buttonNext);
            this.panelFooter.Controls.Add(this.buttonFinish);
            this.panelFooter.Controls.Add(this.buttonCancel);
            this.panelFooter.Controls.Add(this.labelSeparator);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 335);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(469, 46);
            this.panelFooter.TabIndex = 14;
            // 
            // userControlClusterTypePage
            // 
            this.userControlClusterTypePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClusterTypePage.Location = new System.Drawing.Point(0, 0);
            this.userControlClusterTypePage.Name = "userControlClusterTypePage";
            this.userControlClusterTypePage.Size = new System.Drawing.Size(469, 335);
            this.userControlClusterTypePage.TabIndex = 15;
            // 
            // AddClusterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(469, 381);
            this.Controls.Add(this.userControlClusterTypePage);
            this.Controls.Add(this.panelFooter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddClusterForm";
            this.Text = "Cluster";
            this.Load += new System.EventHandler(this.AddClusterForm_Load);
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.Panel panelFooter;
        private UserControlClusterTypePage userControlClusterTypePage;
    }
}