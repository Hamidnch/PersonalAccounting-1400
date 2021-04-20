using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class BankConfig : EntityTypeConfiguration<Bank>
    {
        public BankConfig()
        {
            ToTable("Banks") //, "nch");
                .HasKey(b => b.Id);
            Property(b => b.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(b => b.Name).IsRequired().HasMaxLength(50);
            Property(b => b.Department).IsRequired().HasMaxLength(50);
            Property(b => b.CreatedOn).HasColumnType("datetime");
            Property(b => b.LastUpdate).HasColumnType("datetime");
            Property(b => b.Status).IsOptional();
            Property(b => b.Description).IsOptional().IsMaxLength();
            Property(b => b.Concurrency).IsConcurrencyToken(); //.IsRowVersion();

            //Relationship
            HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);
        }
    }
}
