using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class IncomeConfig : EntityTypeConfiguration<Income>
    {
        public IncomeConfig()
        {
            ToTable("Incomes") //, "nch");
                .HasKey(i => i.Id);
            Property(i => i.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(i => i.IncomeDate).HasColumnType("datetime").IsRequired();
            Property(i => i.Amount).IsRequired();
            Property(i => i.ReceivedBy).IsOptional();
            Property(i => i.CreatedOn).HasColumnType("datetime");
            Property(i => i.LastUpdate).HasColumnType("datetime");
            Property(i => i.Concurrency).IsConcurrencyToken();//.IsRowVersion();

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