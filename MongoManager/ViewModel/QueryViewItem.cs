using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoManager.ViewModel
{
    public class QueryViewItem
    {
        public string OpId { get; set; }

        public bool Active { get; set; }

        public string Client { get; set; }

        public bool WaitingForLock { get; set; }

        public string Operation { get; set; }

        public string Namespace { get; set; }

        public string Query { get; set; }

        public int SecRunning { get; set; }
    }
}
