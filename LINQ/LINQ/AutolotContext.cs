namespace LINQ
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AutolotContext : DbContext
    {
       public AutolotContext()
            : base("name=AutolotContext")
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Mark> Marks { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}