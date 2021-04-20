using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class TransferMoneyConfig : EntityTypeConfiguration<TransferMoney>
    {
        public TransferMoneyConfig()
        {
            ToTable("TransferMonies") //, "nch");
                .HasKey(f => f.Id);
            Property(f => f.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(i => i.Amount).IsRequired();
            Property(i => i.OriginFundId).IsRequired();
            Property(i => i.DestinationFundId).IsRequired();
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
