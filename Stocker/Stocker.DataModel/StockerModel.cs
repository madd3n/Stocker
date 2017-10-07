namespace Stocker.DataModel
{
    using Entities;
    using System.Data.Entity;

    public class StockerModel : DbContext
    {
        // Your context has been configured to use a 'StockerModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Stocker.DataModel.StockerModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StockerModel' 
        // connection string in the application configuration file.
        public StockerModel()
            : base("StockerModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Product> Product{ get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}