using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DX男士服装进销存.Models.Mapping
{
    public class Table_UserMessageMap : EntityTypeConfiguration<Table_UserMessage>
    {
        public Table_UserMessageMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LoginName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LoginPassWord)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.LoginPassWord2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RealName)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Level)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Address)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Table_UserMessage");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LoginName).HasColumnName("LoginName");
            this.Property(t => t.LoginPassWord).HasColumnName("LoginPassWord");
            this.Property(t => t.LoginPassWord2).HasColumnName("LoginPassWord2");
            this.Property(t => t.RealName).HasColumnName("RealName");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.Level).HasColumnName("Level");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.ReMark).HasColumnName("ReMark");
            this.Property(t => t.IsCanuse).HasColumnName("IsCanuse");

            // Relationships
            this.HasRequired(t => t.Table_UserMessage2)
                .WithOptional(t => t.Table_UserMessage1);

        }
    }
}
