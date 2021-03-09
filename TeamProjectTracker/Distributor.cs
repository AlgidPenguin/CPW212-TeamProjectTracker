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

        // TODO: Think/discuss about potentially creating another class/table in order to have Stock and Electronic
        // so that the information is together and linked directly between the distributor and electronic/stock
        /// <summary>
        /// The quantity of electronics in stock
        /// </summary>
        public int Stock { get; set; }

        // Refer to TODO up above
        /// <summary>
        /// The electronic being sold by the distributor
        /// </summary>
        public virtual Electronic Electronic { get; set; }
    }
}
