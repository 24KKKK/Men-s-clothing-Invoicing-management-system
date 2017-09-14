using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DX男士服装进销存.Models.Mapping
{
    public class Table_GoodsInMap : EntityTypeConfiguration<Table_GoodsIn>
    {
        public Table_GoodsInMap()
        {
            // Primary Key
            this.HasKey(t => t.GoodsID);

            // Properties
            this.Property(t => t.GoodsID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StroName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GoodsName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GoodsUnit)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GoodsColor)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GoodsSize)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GoodsLeibie)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.GoodsShouldJijie)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GoodsPinpai)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Table_GoodsIn");
            this.Property(t => t.GoodsID).HasColumnName("GoodsID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.StroName).HasColumnName("StroName");
            this.Property(t => t.GoodsName).HasColumnName("GoodsName");
            this.Property(t => t.GoodsNum).HasColumnName("GoodsNum");
            this.Property(t => t.GoodsUnit).HasColumnName("GoodsUnit");
            this.Property(t => t.GoodsInPrice).HasColumnName("GoodsInPrice");
            this.Property(t => t.GoodsSellPrice).HasColumnName("GoodsSellPrice");
            this.Property(t => t.GoodsShouldPay).HasColumnName("GoodsShouldPay");
            this.Property(t => t.GoodsRealPay).HasColumnName("GoodsRealPay");
            this.Property(t => t.GoodsRemark).HasColumnName("GoodsRemark");
            this.Property(t => t.GoodsInDateTime).HasColumnName("GoodsInDateTime");
            this.Property(t => t.Flage).HasColumnName("Flage");
            this.Property(t => t.GoodsColor).HasColumnName("GoodsColor");
            this.Property(t => t.GoodsSize).HasColumnName("GoodsSize");
            this.Property(t => t.GoodsLeibie).HasColumnName("GoodsLeibie");
            this.Property(t => t.GoodsShouldJijie).HasColumnName("GoodsShouldJijie");
            this.Property(t => t.GoodsPinpai).HasColumnName("GoodsPinpai");

            // Relationships
            this.HasRequired(t => t.Table_UserMessage)
                .WithMany(t => t.Table_GoodsIn)
                .HasForeignKey(d => d.ID);

        }
    }
}
