using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DX男士服装进销存.Models.Mapping
{
    public class Table_StorMap : EntityTypeConfiguration<Table_Stor>
    {
        public Table_StorMap()
        {
            // Primary Key
            this.HasKey(t => t.GoodsID);

            // Properties
            this.Property(t => t.KcID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GoodsID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KcName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KcGoodsName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KcUnit)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Table_Stor");
            this.Property(t => t.KcID).HasColumnName("KcID");
            this.Property(t => t.GoodsID).HasColumnName("GoodsID");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.KcName).HasColumnName("KcName");
            this.Property(t => t.KcGoodsName).HasColumnName("KcGoodsName");
            this.Property(t => t.KcNumber).HasColumnName("KcNumber");
            this.Property(t => t.KcJingGaoNumber).HasColumnName("KcJingGaoNumber");
            this.Property(t => t.KcDataTime).HasColumnName("KcDataTime");
            this.Property(t => t.KcUnit).HasColumnName("KcUnit");
            this.Property(t => t.KcGoodsPrice).HasColumnName("KcGoodsPrice");
            this.Property(t => t.KcGoodsSellPrice).HasColumnName("KcGoodsSellPrice");
            this.Property(t => t.KcRemark).HasColumnName("KcRemark");
        }
    }
}
