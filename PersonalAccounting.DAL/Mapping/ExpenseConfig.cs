using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class ExpenseConfig : EntityTypeConfiguration<Expense>
    {
        public ExpenseConfig()
        {
            ToTable("Expenses") //, "nch");
                .HasKey(e => e.Id);
            Property(e => e.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.ArticleId).IsRequired();
            Property(e => e.Count).IsRequired();
            Property(e => e.Price).IsRequired();
            Property(e => e.ByPersonId).IsRequired();
            Property(e => e.Description).IsOptional().IsMaxLength();
            Property(e => e.Concurrency).IsConcurrencyToken();//.IsRowVersion();

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
