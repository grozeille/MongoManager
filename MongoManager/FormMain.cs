using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoManager.Model;

namespace MongoManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private IList<Server> servers = new List<Server>();

        private void addServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addServerForm = new AddServerForm();
            if (addServerForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.AddServer(addServerForm.Hostname, addServerForm.Login, addServerForm.Password);
            }
        }

        private void AddServer(string hostname, string login, string password)
        {
            servers.Add(new Server { Hostname = hostname, Login = login, Password = password });
            var node = this.treeViewMain.Nodes["NodeServers"].Nodes.Add(hostname);
            node.Text = hostname;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.treeViewMain.Nodes["NodeServers"].Expand();
            this.treeViewMain.Nodes["NodeClusters"].Expand();

            this.LoadData();
        }

        private void addClusterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addCluster = new AddClusterForm();
            if (addCluster.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
            }
        }

        private void LoadData()
        {
            throw new NotImplementedException();
        }

        private void SaveData()
        {
            throw new NotImplementedException();
        }
    }
}
