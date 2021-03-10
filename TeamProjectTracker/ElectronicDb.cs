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
        /// Retrieves all the electronics currently registered in the database
        /// </summary>
        /// <returns>List of all electronics</returns>
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

        public static List<String> GetAllCategories()
        {
            using(TrackingContext context = new TrackingContext())
            {
                List<String> allCategories =
                    (from elect in context.Electronics
                     select elect.Category).Distinct().ToList();

                return allCategories;
            }
        }

        /// <summary>
        /// Adds a new electronic into the database
        /// </summary>
        /// <param name="elect">The electronic to add to the database</param>
        /// <returns>Electronic that was added</returns>
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
        /// Updates an electronic that currently exists in the database
        /// </summary>
        /// <param name="elect">The electronic to update</param>
        /// <returns>Electronic that was updated</returns>
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
        /// Accesses the database and deletes the electronic that was passed in
        /// </summary>
        /// <param name="id">The id of the electronic to delete</param>
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
