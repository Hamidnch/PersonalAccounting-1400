using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            ToTable("Users") //, "nch");
                .HasKey(u => u.Id);
            Property(u => u.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(u => u.UserName).HasMaxLength(256).IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_Username") { IsUnique = true })); ;
            Property(u => u.Password).HasMaxLength(128).IsRequired();
            Property(u => u.CreatedOn).HasColumnType("datetime").IsOptional();
            Property(u => u.LastUpdate).HasColumnType("datetime").IsOptional();
            Property(u => u.LastActivityDate).HasColumnType("datetime").IsOptional();
            Property(u => u.LastLockoutDate).HasColumnType("datetime").IsOptional();
            Property(u => u.LastLoginDate).HasColumnType("datetime").IsOptional();
            Property(u => u.LastPasswordChangedDate).HasColumnType("datetime").IsOptional();
            Property(u => u.LastPasswordFailureDate).HasColumnType("datetime").IsOptional();
            Property(u => u.Status).HasMaxLength(10);
            Property(u => u.Ip).HasMaxLength(19).IsOptional();
            Property(u => u.Email).HasMaxLength(255).IsOptional();
            Property(u => u.Description).IsMaxLength().IsOptional();
            Property(u => u.Concurrency).IsConcurrencyToken();//.IsRowVersion();

            //Relationships
            //HasOptional(u => u.Role)
            //    .WithMany()
            //    .HasForeignKey(u => u.RoleId)
            //    .WillCascadeOnDelete(false);

            //   HasRequired(u => u.Role)
            //.WithMany(r => r.Users)
            //.HasForeignKey(u => u.RoleId)
            //.WillCascadeOnDelete(false);

            //HasRequired(q => q.Person)
            //    .WithRequiredPrincipal(p => p.User);

            // HasOptional(t => t.Person)
            //.WithMany()
            //.Map(d => d.MapKey("PersonId"));

            HasOptional(u => u.SelfUser)
                .WithMany()
                .HasForeignKey(u => u.CreatedBy)
                .WillCascadeOnDelete(false);

            HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);

            //Many to Many
            HasMany(t => t.Roles)
                .WithMany(c => c.Users)
                .Map(t => t.ToTable("UserRoles")
                    .MapLeftKey("UserId")
                    .MapRightKey("RoleId"));

            //HasMany(r => r.Roles)
            //    .WithMany(u => u.Users)
            //    .Map(m =>
            //    {
            //        m.ToTable("UserRoles", "nch");
            //        m.MapLeftKey("UserId");
            //        m.MapRightKey("RoleId");
            //    });

            //HasRequired(u => u.Role)
            //    .WithMany(r => r.Users)
            //    .HasForeignKey(u => u.RoleId);

            //HasMany(r => r.Roles)
            //    .WithMany(u => u.Users)
            //    .Map(m =>
            //    {
            //        m.ToTable("UsersRoles", "nch");
            //        m.MapLeftKey("UserId");
            //        m.MapRightKey("RoleId");
            //    });
        }
    }
}
