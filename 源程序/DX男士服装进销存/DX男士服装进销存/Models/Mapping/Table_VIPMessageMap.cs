using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DX男士服装进销存.Models.Mapping
{
    public class Table_VIPMessageMap : EntityTypeConfiguration<Table_VIPMessage>
    {
        public Table_VIPMessageMap()
        {
            // Primary Key
            this.HasKey(t => t.VIPID);

            // Properties
            this.Property(t => t.VIPID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VIPName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VIPPhone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.VIPAddress)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Table_VIPMessage");
            this.Property(t => t.VIPID).HasColumnName("VIPID");
            this.Property(t => t.VIPName).HasColumnName("VIPName");
            this.Property(t => t.VIPPhone).HasColumnName("VIPPhone");
            this.Property(t => t.VIPAddress).HasColumnName("VIPAddress");
            this.Property(t => t.VIPZhekou).HasColumnName("VIPZhekou");
            this.Property(t => t.Flage).HasColumnName("Flage");
            this.Property(t => t.VIPRemrk).HasColumnName("VIPRemrk");
            this.Property(t => t.VIPBirtheDay).HasColumnName("VIPBirtheDay");
        }
    }
}
