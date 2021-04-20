using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class MeasurementUnitConfig : EntityTypeConfiguration<MeasurementUnit>
    {
        public MeasurementUnitConfig()
        {
            ToTable("MeasurementUnits") //, "nch");
                .HasKey(mu => mu.Id);
            Property(mu => mu.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(mu => mu.Name).IsRequired().HasMaxLength(50);
            Property(mu => mu.CreatedOn).HasColumnType("datetime");
            Property(mu => mu.LastUpdate).HasColumnType("datetime");
            Property(mu => mu.Concurrency).IsConcurrencyToken();//.IsRowVersion();

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
