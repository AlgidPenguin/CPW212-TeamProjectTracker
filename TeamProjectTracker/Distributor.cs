using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectTracker
{
    /// <summary>
    /// Represents a single distributor of products
    /// </summary>
    public class Distributor
    {
        /// <summary>
        /// The unique identifier of the distributor
        /// </summary>
        [Key]
        public int DistibutorID { get; set; }

        /// <summary>
        /// The name of the distributor
        /// </summary>
        public string DistributorName { get; set; }

        /// <summary>
        /// The quantity of total electronics in stock
        /// </summary>
        public int Stock { get; set; }
    }
}
