using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventsReminder.DataAccess.Configurations
{
    public class NotificationCategoryConfiguration
    {
        public void Configure(EntityTypeBuilder<NotificationCategory> builder)
        {
            builder
                .ToTable("NotificationsCategories");
            builder
                .HasKey(s => s.NotificationCategoryId);
            builder
               .HasOne(s => s.Category)
               .WithMany(a => a.NotificationsCategories)
               .HasForeignKey(s => s.CategoryId);
            builder
               .HasOne(s => s.Notification)
               .WithMany(n => n.NotificationsCategories)
               .HasForeignKey(s => s.NotificationId);
        }
    }
}
