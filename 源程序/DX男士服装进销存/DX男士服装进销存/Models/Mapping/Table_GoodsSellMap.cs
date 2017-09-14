using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DX男士服装进销存.Models.Mapping
{
    public class Table_GoodsSellMap : EntityTypeConfiguration<Table_GoodsSell>
    {
        public Table_GoodsSellMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SellID, t.GoodsName });

            // Properties
            this.Property(t => t.SellID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KcID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GoodsID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GoodsName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Table_GoodsSell");
            this.Property(t => t.SellID).HasColumnName("SellID");
            this.Property(t => t.KcID).HasColumnName("KcID");
            this.Property(t => t.GoodsID).HasColumnName("GoodsID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.GoodsName).HasColumnName("GoodsName");
            this.Property(t => t.SellGoodsNumber).HasColumnName("SellGoodsNumber");
            this.Property(t => t.SellGoodsTime).HasColumnName("SellGoodsTime");
            this.Property(t => t.SellPrice).HasColumnName("SellPrice");
            this.Property(t => t.SellShouldPay).HasColumnName("SellShouldPay");
            this.Property(t => t.SellRealPay).HasColumnName("SellRealPay");
            this.Property(t => t.SellRemark).HasColumnName("SellRemark");
            this.Property(t => t.Sellflage).HasColumnName("Sellflage");

            // Relationships
            this.HasRequired(t => t.Table_UserMessage)
                .WithMany(t => t.Table_GoodsSell)
                .HasForeignKey(d => d.ID);

        }
    }
}
