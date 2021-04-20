using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class PersonConfig : EntityTypeConfiguration<Person>
    {
        public PersonConfig()
        {
            ToTable("Persons") //, "nch");
                .HasKey(p => p.Id);
            Property(p => p.Id).HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.FullName).IsRequired().HasMaxLength(50);
            Property(u => u.CreatedOn).HasColumnType("datetime");
            Property(u => u.LastUpdate).HasColumnType("datetime");
            //Property(p => p.Picture).HasColumnType("image");
            Property(p => p.Status).IsOptional();
            Property(p => p.Description).IsOptional().IsMaxLength();
            Property(p => p.Concurrency).IsConcurrencyToken();//.IsRowVersion();

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
