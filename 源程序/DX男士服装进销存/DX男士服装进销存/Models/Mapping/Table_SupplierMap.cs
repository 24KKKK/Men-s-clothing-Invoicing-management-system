using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DX男士服装进销存.Models.Mapping
{
    public class Table_SupplierMap : EntityTypeConfiguration<Table_Supplier>
    {
        public Table_SupplierMap()
        {
            // Primary Key
            this.HasKey(t => t.CompanyID);

            // Properties
            this.Property(t => t.CompanyID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompanyDirector)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompanyPhone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CompanyAddress)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Table_Supplier");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.CompanyDirector).HasColumnName("CompanyDirector");
            this.Property(t => t.CompanyPhone).HasColumnName("CompanyPhone");
            this.Property(t => t.CompanyAddress).HasColumnName("CompanyAddress");
            this.Property(t => t.CompanyReMark).HasColumnName("CompanyReMark");
            this.Property(t => t.InDateTime).HasColumnName("InDateTime");
            this.Property(t => t.IsUsed).HasColumnName("IsUsed");
        }
    }
}
