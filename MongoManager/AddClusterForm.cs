using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MongoManager
{
    public partial class AddClusterForm : Form
    {
        //private IList<UserControl>

        public AddClusterForm()
        {
            InitializeComponent();
        }

        private void AddClusterForm_Load(object sender, EventArgs e)
        {
            this.userControlClusterTypePage.Visible = true;
            this.buttonBack.Enabled = false;
            this.buttonNext.Enabled = true;
            this.buttonFinish.Enabled = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }
    }
}
