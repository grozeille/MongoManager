namespace MongoManager
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("localhost");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("192.168.1.2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Servers", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("mongod");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("MySimpleCluster", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("mongod1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("mongod2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("mongod3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("ClusterWithReplication", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("mongos");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("mongoconfig1");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("mongod1");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("mongod2");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("ClusterWithSharding", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("mongos");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("mongoconfig1");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("mongod1");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("mongod2");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("mongod3");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("mongoRepl1", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("mongod1");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("mongoRepl2", new System.Windows.Forms.TreeNode[] {
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("ClusterWithShardingAndReplication", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode20,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Clusters", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode14,
            treeNode23});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.contextMenuStripServers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripCluster = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addClusterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cluster = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clusterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClusterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addServerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detectClusterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectClusterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripServers.SuspendLayout();
            this.contextMenuStripCluster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripServers
            // 
            this.contextMenuStripServers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addServerToolStripMenuItem});
            this.contextMenuStripServers.Name = "contextMenuStripServers";
            this.contextMenuStripServers.Size = new System.Drawing.Size(131, 26);
            // 
            // addServerToolStripMenuItem
            // 
            this.addServerToolStripMenuItem.Name = "addServerToolStripMenuItem";
            this.addServerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addServerToolStripMenuItem.Text = "Add server";
            this.addServerToolStripMenuItem.Click += new System.EventHandler(this.addServerToolStripMenuItem_Click);
            // 
            // contextMenuStripCluster
            // 
            this.contextMenuStripCluster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClusterToolStripMenuItem,
            this.detectClusterToolStripMenuItem1});
            this.contextMenuStripCluster.Name = "contextMenuStripCluster";
            this.contextMenuStripCluster.Size = new System.Drawing.Size(153, 70);
            // 
            // addClusterToolStripMenuItem
            // 
            this.addClusterToolStripMenuItem.Name = "addClusterToolStripMenuItem";
            this.addClusterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addClusterToolStripMenuItem.Text = "Add cluster";
            this.addClusterToolStripMenuItem.Click += new System.EventHandler(this.addClusterToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(822, 551);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewMain
            // 
            this.treeViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMain.ImageIndex = 2;
            this.treeViewMain.ImageList = this.imageList;
            this.treeViewMain.Location = new System.Drawing.Point(0, 0);
            this.treeViewMain.Name = "treeViewMain";
            treeNode1.Name = "Node3";
            treeNode1.Text = "localhost";
            treeNode2.Name = "Node4";
            treeNode2.Text = "192.168.1.2";
            treeNode3.ContextMenuStrip = this.contextMenuStripServers;
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "NodeServers";
            treeNode3.SelectedImageIndex = 0;
            treeNode3.Text = "Servers";
            treeNode4.Name = "Node6";
            treeNode4.Text = "mongod";
            treeNode5.Name = "Node5";
            treeNode5.Text = "MySimpleCluster";
            treeNode6.Name = "Node8";
            treeNode6.Text = "mongod1";
            treeNode7.Name = "Node9";
            treeNode7.Text = "mongod2";
            treeNode8.Name = "Node10";
            treeNode8.Text = "mongod3";
            treeNode9.Name = "Node7";
            treeNode9.Text = "ClusterWithReplication";
            treeNode10.Name = "Node12";
            treeNode10.Text = "mongos";
            treeNode11.Name = "Node13";
            treeNode11.Text = "mongoconfig1";
            treeNode12.Name = "Node14";
            treeNode12.Text = "mongod1";
            treeNode13.Name = "Node15";
            treeNode13.Text = "mongod2";
            treeNode14.Name = "Node11";
            treeNode14.Text = "ClusterWithSharding";
            treeNode15.Name = "Node17";
            treeNode15.Text = "mongos";
            treeNode16.Name = "Node18";
            treeNode16.Text = "mongoconfig1";
            treeNode17.Name = "Node20";
            treeNode17.Text = "mongod1";
            treeNode18.Name = "Node21";
            treeNode18.Text = "mongod2";
            treeNode19.Name = "Node22";
            treeNode19.Text = "mongod3";
            treeNode20.Name = "Node19";
            treeNode20.Text = "mongoRepl1";
            treeNode21.Name = "Node24";
            treeNode21.Text = "mongod1";
            treeNode22.Name = "Node23";
            treeNode22.Text = "mongoRepl2";
            treeNode23.Name = "Node16";
            treeNode23.Text = "ClusterWithShardingAndReplication";
            treeNode24.ContextMenuStrip = this.contextMenuStripCluster;
            treeNode24.ImageIndex = 1;
            treeNode24.Name = "NodeClusters";
            treeNode24.SelectedImageIndex = 1;
            treeNode24.Text = "Clusters";
            this.treeViewMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode24});
            this.treeViewMain.SelectedImageIndex = 2;
            this.treeViewMain.Size = new System.Drawing.Size(274, 551);
            this.treeViewMain.TabIndex = 0;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "server.png");
            this.imageList.Images.SetKeyName(1, "database.png");
            this.imageList.Images.SetKeyName(2, "accept.png");
            this.imageList.Images.SetKeyName(3, "exclamation.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.cluster);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 551);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(536, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cluster
            // 
            this.cluster.Location = new System.Drawing.Point(4, 22);
            this.cluster.Name = "cluster";
            this.cluster.Padding = new System.Windows.Forms.Padding(3);
            this.cluster.Size = new System.Drawing.Size(536, 549);
            this.cluster.TabIndex = 1;
            this.cluster.Text = "cluster";
            this.cluster.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(536, 549);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "mongos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(536, 549);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "mongoconfig";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(536, 549);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "replset";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(536, 549);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "mongod";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tabControl2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(536, 549);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "addNew";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Controls.Add(this.tabPage10);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(530, 543);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.numericUpDown3);
            this.tabPage8.Controls.Add(this.label4);
            this.tabPage8.Controls.Add(this.numericUpDown2);
            this.tabPage8.Controls.Add(this.comboBox1);
            this.tabPage8.Controls.Add(this.label3);
            this.tabPage8.Controls.Add(this.label2);
            this.tabPage8.Controls.Add(this.label1);
            this.tabPage8.Controls.Add(this.numericUpDown1);
            this.tabPage8.Controls.Add(this.checkBox2);
            this.tabPage8.Controls.Add(this.checkBox1);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(522, 517);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "choose cluster type";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(144, 57);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "replicat number:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(145, 236);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(144, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "shard number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "mongo config:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "mongos instances:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(145, 142);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 97);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Sharding";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "ReplSet";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(522, 517);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "where install";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(522, 517);
            this.tabPage10.TabIndex = 3;
            this.tabPage10.Text = "setup sharding";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clusterToolStripMenuItem,
            this.serversToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(822, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // clusterToolStripMenuItem
            // 
            this.clusterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClusterToolStripMenuItem1,
            this.detectClusterToolStripMenuItem});
            this.clusterToolStripMenuItem.Name = "clusterToolStripMenuItem";
            this.clusterToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clusterToolStripMenuItem.Text = "Clusters";
            // 
            // addClusterToolStripMenuItem1
            // 
            this.addClusterToolStripMenuItem1.Name = "addClusterToolStripMenuItem1";
            this.addClusterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addClusterToolStripMenuItem1.Text = "Add cluster";
            // 
            // serversToolStripMenuItem
            // 
            this.serversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addServerToolStripMenuItem1});
            this.serversToolStripMenuItem.Name = "serversToolStripMenuItem";
            this.serversToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.serversToolStripMenuItem.Text = "Servers";
            // 
            // addServerToolStripMenuItem1
            // 
            this.addServerToolStripMenuItem1.Name = "addServerToolStripMenuItem1";
            this.addServerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addServerToolStripMenuItem1.Text = "Add server";
            // 
            // detectClusterToolStripMenuItem
            // 
            this.detectClusterToolStripMenuItem.Name = "detectClusterToolStripMenuItem";
            this.detectClusterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detectClusterToolStripMenuItem.Text = "Detect cluster";
            // 
            // detectClusterToolStripMenuItem1
            // 
            this.detectClusterToolStripMenuItem1.Name = "detectClusterToolStripMenuItem1";
            this.detectClusterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.detectClusterToolStripMenuItem1.Text = "Detect cluster";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 575);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Mongo Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuStripServers.ResumeLayout(false);
            this.contextMenuStripCluster.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage cluster;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripServers;
        private System.Windows.Forms.ToolStripMenuItem addServerToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCluster;
        private System.Windows.Forms.ToolStripMenuItem addClusterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectClusterToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem clusterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClusterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detectClusterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addServerToolStripMenuItem1;
    }
}

