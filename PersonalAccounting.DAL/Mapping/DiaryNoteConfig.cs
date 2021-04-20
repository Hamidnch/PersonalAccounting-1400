using PersonalAccounting.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PersonalAccounting.DAL.Mapping
{
    public class DiaryNoteConfig : EntityTypeConfiguration<DiaryNote>
    {
        public DiaryNoteConfig()
        {
            ToTable("DiaryNotes") //, "nch");
                .HasKey(b => b.Id);
            Property(b => b.Id)
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(b => b.Date).HasColumnType("datetime");
            //Property(b => b.Note).HasColumnType("ntext");
            Property(b => b.Concurrency).IsConcurrencyToken();

            //Relationship
            HasOptional(p => p.SelfUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete(false);

            HasOptional(p => p.UpdateUser)
                .WithMany()
                .HasForeignKey(p => p.UpdateBy)
                .WillCascadeOnDelete(false);

            HasOptional(u => u.WeatherCondition)
                .WithMany(r => r.DiaryNotes)
                .HasForeignKey(u => u.WeatherConditionId);

            HasOptional(u => u.MentalCondition)
                .WithMany(r => r.DiaryNotes)
                .HasForeignKey(u => u.MentalConditionId);
        }
    }
}
