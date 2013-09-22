using System.Data.Entity;

namespace Model
{
    public class BarberShopDatabaseInitializer : CreateDatabaseIfNotExists<BarberShopContext>
    {
        protected override void Seed(BarberShopContext context)
        {
          /*  Database.SetInitializer(new MigrateDatabaseToLatestVersion<BarberShopContext, Configuration>());*/
            base.Seed(context);
            context.SaveChanges();
        }
    }
}
