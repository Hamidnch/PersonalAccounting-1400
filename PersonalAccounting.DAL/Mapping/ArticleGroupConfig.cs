using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class ArticleGroupConfig : EntityTypeConfiguration<ArticleGroup>
    {
        public ArticleGroupConfig()
        {
            ToTable("ArticleGroups") //, "nch");
                .HasKey(ag => ag.Id);
            Property(ag => ag.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(ag => ag.Name).HasMaxLength(50).IsRequired();
            Property(ag => ag.LatinName).IsOptional();
            Property(ag => ag.CreatedOn).HasColumnType("datetime");
            Property(ag => ag.LastUpdate).HasColumnType("datetime");
            Property(ag => ag.Description).IsOptional().IsMaxLength();
            Property(ag => ag.Concurrency).IsConcurrencyToken();//.IsRowVersion();

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
