using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventsReminder.DataAccess.Configurations
{
    public class DaysOfWeekWhenSendNotificationConfiguration : IEntityTypeConfiguration<DaysOfWeekWhenSendNotification>
    {
        public void Configure(EntityTypeBuilder<DaysOfWeekWhenSendNotification> builder)
        {
            builder
                .ToTable("DaysOfWeekWhenSendNotification");
            builder
                .HasKey(d => d.DaysOfWeekWhenSendNotificationId);
            builder
               .HasOne(ds => ds.DayOfWeek)
               .WithMany(d => d.DaysOfWeekWhenSendNotification)
               .HasForeignKey(ds => ds.DayOfWeekId);
        }
    }
}
