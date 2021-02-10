using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectTracker
{
    class Distributor
    {
        public int DistibutorID { get; set; }

        public string ProductId { get; set; }

        public string DistributorName { get; set; }

        public int Stock { get; set; }

        public virtual Electronic Electronic { get; set; }
    }
}
