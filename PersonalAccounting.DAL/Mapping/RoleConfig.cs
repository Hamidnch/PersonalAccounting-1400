using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class RoleConfig : EntityTypeConfiguration<Role>
    {
        public RoleConfig()
        {
            ToTable("Roles") //, "nch");
            .HasKey(r => r.Id);
            Property(r => r.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(r => r.Name).HasMaxLength(50).IsRequired();
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
