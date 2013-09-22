
using System.Data.Entity;
using System.Runtime.ConstrainedExecution;

namespace Model
{
    public class BarberShopContext:DbContext
    {
        public BarberShopContext()
            : base("BarberShopManager")
        {
            
        }
        public DbSet<UerInfo> UserInfos { get; set; }
        public DbSet<TecCategory> TecCategories { get; set; }
        public DbSet<TecItem> TecItems { get; set; }
        public DbSet<Commodity> Commodities { get; set; }
        public DbSet<CommodityCategory> CommodityCategories { get; set; }
    }


}
