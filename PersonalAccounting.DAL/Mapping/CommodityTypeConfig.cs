using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class CommodityTypeConfig : EntityTypeConfiguration<CommodityType>
    {
        public CommodityTypeConfig()
        {
            ToTable("CommodityTypes") //, "nch");
                .HasKey(it => it.Id);
            Property(it => it.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(it => it.Title).IsRequired().HasMaxLength(50);
            Property(it => it.CreatedOn).HasColumnType("datetime");
            Property(it => it.LastUpdate).HasColumnType("datetime");
            Property(it => it.Concurrency).IsConcurrencyToken();//.IsRowVersion();

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