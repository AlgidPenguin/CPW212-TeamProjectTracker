using System;
using System.Data.Entity;
using System.Linq;

namespace TeamProjectTracker
{
    public class TrackingContext : DbContext
    {
        // Your context has been configured to use a 'TrackingContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TeamProjectTracker.TrackingContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TrackingContext' 
        // connection string in the application configuration file.
        public TrackingContext()
            : base("name=TrackingContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Electronic> Electronics { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}