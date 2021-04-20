using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class FundConfig : EntityTypeConfiguration<Fund>
    {
        public FundConfig()
        {
            ToTable("Funds") //, "nch");
                .HasKey(f => f.Id);
            Property(f => f.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(f => f.Type).IsRequired();
            Property(f => f.Title).IsRequired().HasMaxLength(50);
            Property(f => f.BankAccountId).IsOptional();
            //Property(f => f.FundCurrentValue).IsRequired();
            Property(f => f.CreatedOn).HasColumnType("datetime");
            Property(f => f.LastUpdate).HasColumnType("datetime");
            Property(f => f.Status).IsOptional();
            Property(f => f.Description).IsOptional().IsMaxLength();
            Property(f => f.Concurrency).IsConcurrencyToken();//.IsRowVersion();

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
