using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class MentalConditionConfig : EntityTypeConfiguration<MentalCondition>
    {
        public MentalConditionConfig()
        {
            ToTable("MentalConditions") //, "nch");
                .HasKey(a => a.Id);
            Property(a => a.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Title).HasMaxLength(50).IsRequired();
            Property(a => a.CreatedOn).HasColumnType("datetime");
            Property(a => a.LastUpdate).HasColumnType("datetime");
            Property(a => a.Status).HasMaxLength(50);
            Property(a => a.Description).IsOptional().IsMaxLength();
            Property(a => a.Concurrency).IsConcurrencyToken();//.IsRowVersion();

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
