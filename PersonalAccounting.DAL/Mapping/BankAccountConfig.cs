using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class BankAccountConfig : EntityTypeConfiguration<BankAccount>
    {
        public BankAccountConfig()
        {
            ToTable("BankAccounts") //, "nch");
                .HasKey(ba => ba.Id);
            Property(ba => ba.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(ba => ba.Name).IsRequired().HasMaxLength(50);
            Property(ba => ba.AccountNumber).IsRequired().HasMaxLength(50);
            Property(ba => ba.PersonId).IsRequired();
            Property(ba => ba.BankId).IsRequired();
            Property(ba => ba.CreatedOn).HasColumnType("datetime");
            Property(ba => ba.LastUpdate).HasColumnType("datetime");
            Property(ba => ba.Status).IsOptional();
            Property(ba => ba.Description).IsOptional().IsMaxLength();
            Property(ba => ba.Concurrency).IsConcurrencyToken();//.IsRowVersion();

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
