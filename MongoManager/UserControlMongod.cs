using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoManager.ViewModel;
using System.Threading;

namespace MongoManager
{
    public partial class UserControlMongod : UserControl
    {
        private MongoServer server;

        public UserControlMongod()
        {
            InitializeComponent();
        }

        public void StartMonitoring(MongoServer server)
        {
            this.server = server;

            var thread = new Thread(DoMonitoring);
            thread.IsBackground = true;
            thread.Name = "Monitoring#" + server.Settings.Server.ToString();
            thread.Start();

            
        }

        public void DoMonitoring()
        {
            var database = server.GetDatabase("admin");
            var collection = database.GetCollection("$cmd.sys.inprog");
            var inProg = collection.FindOne();

            var result = inProg["inprog"].AsBsonArray.Select(x =>
            {
                var doc = x.AsBsonDocument;
                var item = new QueryViewItem
                {
                    OpId = doc["opid"].ToString(),
                    Active = doc["active"].AsBoolean,
                    SecRunning = doc["secs_running"].AsInt32,
                    Operation = doc["op"].ToString(),
                    Namespace = doc["ns"].ToString(),
                    Query = doc["query"].ToString(),
                    Client = doc["client"].ToString(),
                    WaitingForLock = doc["waitingForLock"].AsBoolean
                };

                return item;
            });

            this.BeginInvoke(new Action<IEnumerable<QueryViewItem>>(items => 
                {
                    this.queryViewItemBindingSource.DataSource = items;
                    this.queryViewItemBindingSource.ResetBindings(false);
                }), result);
        }
    }
}
