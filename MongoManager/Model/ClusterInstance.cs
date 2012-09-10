using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoManager.Model
{
    public class ClusterInstance : IClusterMember
    {
        public string Name { get; set; }

        public string Hostname { get; set; }

        public int Port { get; set; }

        public ServiceAccountType AccountType { get; set; }

        public string CustomLogin { get; set; }

        public string CustomPassword { get; set; }

        public ServiceStartupType StartupType { get; set; }
    }
}
