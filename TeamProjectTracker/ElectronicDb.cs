using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectTracker
{
    class ElectronicDb
    {
     
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Electronic> GetAllElectronics()
        {
            using (TrackingContext context = new TrackingContext())
            {
                List<Electronic> allElect =
                    (from elect in context.Electronics
                     select elect).ToList();

                return allElect;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elect"></param>
        /// <returns></returns>
        public static Electronic Add(Electronic elect)
        {
            using (TrackingContext context = new TrackingContext())
            {
                context.Electronics.Add(elect);
                context.SaveChanges();

                return elect;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elect"></param>
        /// <returns></returns>
        public static Electronic Update(Electronic elect)
        {
            using (TrackingContext context = new TrackingContext())
            {
                context.Entry(elect).State = EntityState.Modified;

                context.SaveChanges();

                return elect;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id)
        {
            using (TrackingContext context = new TrackingContext())
            {
                Electronic electDelete =
                    (from elect in context.Electronics
                     where elect.ProductId == id
                     select elect).Single();

                context.Entry(electDelete).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
