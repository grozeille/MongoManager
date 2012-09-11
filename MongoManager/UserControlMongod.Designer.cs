namespace MongoManager
{
    partial class UserControlMongod
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewQueries = new System.Windows.Forms.DataGridView();
            this.queryViewItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitingForLockDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namespaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secRunningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryViewItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewQueries);
            this.splitContainer1.Size = new System.Drawing.Size(831, 448);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewQueries
            // 
            this.dataGridViewQueries.AllowUserToAddRows = false;
            this.dataGridViewQueries.AllowUserToDeleteRows = false;
            this.dataGridViewQueries.AutoGenerateColumns = false;
            this.dataGridViewQueries.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewQueries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opIdDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.waitingForLockDataGridViewCheckBoxColumn,
            this.operationDataGridViewTextBoxColumn,
            this.namespaceDataGridViewTextBoxColumn,
            this.queryDataGridViewTextBoxColumn,
            this.secRunningDataGridViewTextBoxColumn});
            this.dataGridViewQueries.DataSource = this.queryViewItemBindingSource;
            this.dataGridViewQueries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQueries.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewQueries.Name = "dataGridViewQueries";
            this.dataGridViewQueries.ReadOnly = true;
            this.dataGridViewQueries.RowHeadersVisible = false;
            this.dataGridViewQueries.Size = new System.Drawing.Size(831, 180);
            this.dataGridViewQueries.TabIndex = 0;
            // 
            // queryViewItemBindingSource
            // 
            this.queryViewItemBindingSource.DataSource = typeof(MongoManager.ViewModel.QueryViewItem);
            // 
            // opIdDataGridViewTextBoxColumn
            // 
            this.opIdDataGridViewTextBoxColumn.DataPropertyName = "OpId";
            this.opIdDataGridViewTextBoxColumn.HeaderText = "OpId";
            this.opIdDataGridViewTextBoxColumn.Name = "opIdDataGridViewTextBoxColumn";
            this.opIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // waitingForLockDataGridViewCheckBoxColumn
            // 
            this.waitingForLockDataGridViewCheckBoxColumn.DataPropertyName = "WaitingForLock";
            this.waitingForLockDataGridViewCheckBoxColumn.HeaderText = "WaitingForLock";
            this.waitingForLockDataGridViewCheckBoxColumn.Name = "waitingForLockDataGridViewCheckBoxColumn";
            this.waitingForLockDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "Operation";
            this.operationDataGridViewTextBoxColumn.HeaderText = "Operation";
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            this.operationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namespaceDataGridViewTextBoxColumn
            // 
            this.namespaceDataGridViewTextBoxColumn.DataPropertyName = "Namespace";
            this.namespaceDataGridViewTextBoxColumn.HeaderText = "Namespace";
            this.namespaceDataGridViewTextBoxColumn.Name = "namespaceDataGridViewTextBoxColumn";
            this.namespaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // queryDataGridViewTextBoxColumn
            // 
            this.queryDataGridViewTextBoxColumn.DataPropertyName = "Query";
            this.queryDataGridViewTextBoxColumn.HeaderText = "Query";
            this.queryDataGridViewTextBoxColumn.Name = "queryDataGridViewTextBoxColumn";
            this.queryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secRunningDataGridViewTextBoxColumn
            // 
            this.secRunningDataGridViewTextBoxColumn.DataPropertyName = "SecRunning";
            this.secRunningDataGridViewTextBoxColumn.HeaderText = "SecRunning";
            this.secRunningDataGridViewTextBoxColumn.Name = "secRunningDataGridViewTextBoxColumn";
            this.secRunningDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UserControlMongod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControlMongod";
            this.Size = new System.Drawing.Size(831, 448);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryViewItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewQueries;
        private System.Windows.Forms.DataGridViewTextBoxColumn opIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn waitingForLockDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namespaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secRunningDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource queryViewItemBindingSource;
    }
}
