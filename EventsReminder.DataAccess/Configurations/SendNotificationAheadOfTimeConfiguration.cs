using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventsReminder.DataAccess.Configurations
{
    public class SendNotificationAheadOfTimeConfiguration : IEntityTypeConfiguration<SendNotificationAheadOfTime>
    {
        public void Configure(EntityTypeBuilder<SendNotificationAheadOfTime> builder)
        {
            builder
                .ToTable("SendNotificationsAheadOfTime");
            builder
                .HasKey(s => s.SendNotificationAheadOfTimeId);
            builder
               .HasOne(s => s.AheadOfTime)
               .WithMany(a => a.SendNotificationAheadOfTime)
               .HasForeignKey(s => s.AheadOfTimeId);
            builder
               .HasOne(s => s.Notification)
               .WithMany(n => n.SendNotificationAheadOfTime)
               .HasForeignKey(s => s.NotificationId);
        }
    }
}
