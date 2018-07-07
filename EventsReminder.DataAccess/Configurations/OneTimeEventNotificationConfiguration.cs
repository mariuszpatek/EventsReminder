using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventsReminder.DataAccess.Configurations
{
    public class OneTimeEventNotificationConfiguration : IEntityTypeConfiguration<OneTimeEventNotification>
    {
        public void Configure(EntityTypeBuilder<OneTimeEventNotification> builder)
        {
            builder
                .Property(n => n.FutureEventDate)
                .IsRequired()
                .HasColumnType("Date");
        }
    }
}
