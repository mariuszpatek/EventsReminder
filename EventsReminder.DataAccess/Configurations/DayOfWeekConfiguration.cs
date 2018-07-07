using EventsReminder.Common;
using EventsReminder.Common.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace EventsReminder.DataAccess.Configurations
{
    public class DayOfWeekConfiguration : IEntityTypeConfiguration<Model.Models.DayOfWeek>
    {
        public void Configure(EntityTypeBuilder<Model.Models.DayOfWeek> builder)
        {
            builder
                .ToTable("DaysOfWeek");
            builder
                .HasKey(m => m.DayOfWeekId);
            builder
                .Property(m => m.DayOfWeekId)
                .ValueGeneratedNever();
            builder
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100);

            foreach (var item in (Enum.GetValues(typeof(DayOfWeekEnum))))
            {
                builder
                    .HasData(new Model.Models.DayOfWeek
                    {
                        DayOfWeekId = (int)item, Name = ((DayOfWeekEnum)item).GetEnumDisplayName()
                    });
            }
        }
    }
}
