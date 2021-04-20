using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class PermissionConfig : EntityTypeConfiguration<Permission>
    {
        public PermissionConfig()
        {
            ToTable("Permissions") //, "nch");
                .HasKey(r => r.Id);
            Property(r => r.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(r => r.Name).HasMaxLength(50).IsRequired();
            Property(r => r.IsSelected).IsRequired();
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

            //Many to Many
            HasMany(t => t.Roles)
                .WithMany(c => c.Permissions)
                .Map(t => t.ToTable("RolePermissions")
                    .MapLeftKey("PermissionId")
                    .MapRightKey("RoleId"));

            HasMany(t => t.FormEntities)
                .WithMany(c => c.Permissions)
                .Map(t => t.ToTable("FormEntityPermissions")
                    .MapLeftKey("PermissionId")
                    .MapRightKey("FormEntityId"));

            //HasRequired(u => u.Role)
            //    .WithMany()
            //    .HasForeignKey(u => u.RoleId)
            //    .WillCascadeOnDelete(false);

            //HasRequired(u => u.FormEntity)
            //    .WithMany()
            //    .HasForeignKey(u => u.FormEntityId)
            //    .WillCascadeOnDelete(false);
        }
    }
}
