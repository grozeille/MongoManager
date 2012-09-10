using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoManager.Model
{
    public class ClusterShard : IClusterMember
    {
        public IList<ClusterInstance> MongoS { get; set; }

        public IList<ClusterInstance> MongoConfig { get; set; }

        public IList<IClusterMember> Members { get; set; }
    }
}
