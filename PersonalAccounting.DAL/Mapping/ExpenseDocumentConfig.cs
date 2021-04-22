using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class ExpenseDocumentConfig : EntityTypeConfiguration<ExpenseDocument>
    {
        public ExpenseDocumentConfig()
        {
            ToTable("ExpenseDocuments") //, "nch");
                .HasKey(ed => ed.Id);
            Property(ed => ed.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(ed => ed.UserId).IsRequired();
            Property(ed => ed.RegisterDate).HasColumnType("datetime");
            Property(ed => ed.CreatedOn).HasColumnType("datetime");
            Property(ed => ed.LastUpdate).HasColumnType("datetime");
            Property(ed => ed.Concurrency).IsConcurrencyToken();//.IsRowVersion();

            //Relationship
            HasRequired(u => u.User)
                .WithMany(r => r.ExpenseDocuments)
                .HasForeignKey(u => u.UserId);

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