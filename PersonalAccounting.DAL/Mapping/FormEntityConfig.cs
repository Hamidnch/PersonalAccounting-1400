using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class FormEntityConfig : EntityTypeConfiguration<FormEntity>
    {
        public FormEntityConfig()
        {
            ToTable("FormEntities") //, "nch");
                .HasKey(r => r.Id);
            Property(r => r.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(r => r.Name).HasMaxLength(255).IsRequired();
            Property(r => r.SystemName).HasMaxLength(200).IsRequired();
            Property(r => r.CreatedOn).HasColumnType("datetime");
            Property(r => r.LastUpdate).HasColumnType("datetime");
            Property(r => r.Concurrency).IsConcurrencyToken();//.IsRowVersion();

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
