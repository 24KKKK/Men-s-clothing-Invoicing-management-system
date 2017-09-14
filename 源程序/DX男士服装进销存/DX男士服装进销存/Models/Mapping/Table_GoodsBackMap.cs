using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DX男士服装进销存.Models.Mapping
{
    public class Table_GoodsBackMap : EntityTypeConfiguration<Table_GoodsBack>
    {
        public Table_GoodsBackMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ThGoodsID, t.GoodsID, t.SellID });

            // Properties
            this.Property(t => t.ThGoodsID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KcID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GoodsID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SellID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ThGoodsName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Table_GoodsBack");
            this.Property(t => t.ThGoodsID).HasColumnName("ThGoodsID");
            this.Property(t => t.KcID).HasColumnName("KcID");
            this.Property(t => t.GoodsID).HasColumnName("GoodsID");
            this.Property(t => t.SellID).HasColumnName("SellID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ThGoodsName).HasColumnName("ThGoodsName");
            this.Property(t => t.ThGoodsNumber).HasColumnName("ThGoodsNumber");
            this.Property(t => t.ThGoodsTime).HasColumnName("ThGoodsTime");
            this.Property(t => t.ThGoodsPrice).HasColumnName("ThGoodsPrice");
            this.Property(t => t.ThRealPay).HasColumnName("ThRealPay");
            this.Property(t => t.ThHasPay).HasColumnName("ThHasPay");
            this.Property(t => t.ThRemark).HasColumnName("ThRemark");
        }
    }
}
