using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventsReminder.DataAccess.Configurations
{
    public class PeriodicEventNotificationConfiguration : IEntityTypeConfiguration<PeriodicEventNotification>
    {
        public void Configure(EntityTypeBuilder<PeriodicEventNotification> builder)
        {
            builder
                .HasMany(n => n.DaysOfWeekWhenSendNotification)
                .WithOne(d => d.Notification)
                .HasForeignKey(d => d.NotificationId);
        }
    }
}
