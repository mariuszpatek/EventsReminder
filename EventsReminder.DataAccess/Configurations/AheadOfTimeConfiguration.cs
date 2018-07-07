using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventsReminder.DataAccess.Configurations
{
    public class AheadOfTimeConfiguration : IEntityTypeConfiguration<AheadOfTime>
    {

        public void Configure(EntityTypeBuilder<AheadOfTime> builder)
        {
            builder
                .ToTable("AheadOfTime");
            builder
                .HasKey(m => m.AheadOfTimeId);
            builder
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(m => m.NumberOfDays)
                .IsRequired();
            builder
                .HasData
                (
                    new AheadOfTime { AheadOfTimeId = 1, Name = "Tego samego dnia", NumberOfDays = 0 },
                    new AheadOfTime { AheadOfTimeId = 2, Name = "Jeden dzień wcześniej", NumberOfDays = 1 },
                    new AheadOfTime { AheadOfTimeId = 3, Name = "Dwa dni wcześniej", NumberOfDays = 2 },
                    new AheadOfTime { AheadOfTimeId = 4, Name = "Trzy dni wcześniej", NumberOfDays = 3 },
                    new AheadOfTime { AheadOfTimeId = 5, Name = "Tydzień wcześniej", NumberOfDays = 7 }
                );
        }
    }
}
