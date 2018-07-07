using EventsReminder.Common.Enums;
using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EventsReminder.DataAccess.Configurations
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder
                .ToTable("Notifications")
                .HasDiscriminator(n => n.NotificationType)
                .HasValue<OneTimeEventNotification>(NotificationType.OneTimeEvent)
                .HasValue<HistoricEventNotification>(NotificationType.HistoricEvent)
                .HasValue<PeriodicEventNotification>(NotificationType.PeriodicEvent);
            builder
                .HasKey(n => n.NotificationId);
            builder
                .Property(n => n.Name)
                .IsRequired()
                .HasMaxLength(255);
            builder
                .Property(n => n.IsActive)
                .HasDefaultValue(true);
            builder
                .Property(n => n.SendingHour)
                .IsRequired();
            builder
                .Property(m => m.Description)
                .IsRequired();
            builder
                .Property(m => m.MessageType)
                .HasConversion(
                    v => v.ToString(),
                    v => (MessageType)Enum.Parse(typeof(MessageType), v)
                );
            builder
                .Property(n => n.NotificationType)
                .HasConversion(
                        v => v.ToString(),
                        v => (NotificationType)Enum.Parse(typeof(NotificationType), v)
                    );
            builder
                .HasOne(n => n.User)
                .WithMany(u => u.Notifications)
                .HasForeignKey(n => n.UserId);
            builder
                .HasMany(n => n.Messages)
                .WithOne(m => m.Notification)
                .HasForeignKey(m => m.NotificationId);

            builder
                .Property<DateTime>("CreatedUtc")
                .HasDefaultValueSql("GetUtcDate()");

        }
    }
}
