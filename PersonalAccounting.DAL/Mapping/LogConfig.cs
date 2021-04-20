using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class LogConfig : EntityTypeConfiguration<Log>
    {
        public LogConfig()
        {
            ToTable("Logs") //, "nch");
                .HasKey(f => f.Id);
            Property(f => f.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(r => r.ShortMessage).HasMaxLength(255).IsRequired();
            Property(r => r.FullMessage).IsMaxLength().IsRequired();
            Property(r => r.FormName).HasMaxLength(500).IsOptional();
            Property(r => r.Action).HasMaxLength(50).IsOptional();
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
