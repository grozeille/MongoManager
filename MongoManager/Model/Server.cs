using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoManager.Model
{
    public class Server
    {
        public string Hostname { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string LocalPath { get; set; }
    }
}
