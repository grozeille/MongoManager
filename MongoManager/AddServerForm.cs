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
    public partial class AddServerForm : Form
    {
        public AddServerForm()
        {
            InitializeComponent();
        }

        public string Hostname { get; private set; }

        public string Login { get; private set; }

        public string Password { get; private set; }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Hostname = this.textBoxHost.Text;
            this.Login = this.textBoxLogin.Text;
            this.Password = this.maskedTextBoxPassword.Text;
        }
    }
}
