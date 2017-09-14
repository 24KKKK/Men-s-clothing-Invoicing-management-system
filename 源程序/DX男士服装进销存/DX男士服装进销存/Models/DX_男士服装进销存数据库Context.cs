using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DX男士服装进销存.Models.Mapping;

namespace DX男士服装进销存.Models
{
    public partial class DX_男士服装进销存数据库Context : DbContext
    {
        static DX_男士服装进销存数据库Context()
        {
            Database.SetInitializer<DX_男士服装进销存数据库Context>(null);
        }

        public DX_男士服装进销存数据库Context()
            : base("Name=DX_男士服装进销存数据库Context")
        {
        }

        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Table_GoodsBack> Table_GoodsBack { get; set; }
        public DbSet<Table_GoodsIn> Table_GoodsIn { get; set; }
        public DbSet<Table_GoodsSell> Table_GoodsSell { get; set; }
        public DbSet<Table_Stor> Table_Stor { get; set; }
        public DbSet<Table_Supplier> Table_Supplier { get; set; }
        public DbSet<Table_UserMessage> Table_UserMessage { get; set; }
        public DbSet<Table_VIPMessage> Table_VIPMessage { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new Table_GoodsBackMap());
            modelBuilder.Configurations.Add(new Table_GoodsInMap());
            modelBuilder.Configurations.Add(new Table_GoodsSellMap());
            modelBuilder.Configurations.Add(new Table_StorMap());
            modelBuilder.Configurations.Add(new Table_SupplierMap());
            modelBuilder.Configurations.Add(new Table_UserMessageMap());
            modelBuilder.Configurations.Add(new Table_VIPMessageMap());
        }
    }
}
