using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoManager.Model
{
    public class ClusterReplSet : IClusterMember
    {
        public IList<ClusterInstance> Members { get; set; }
    }
}
