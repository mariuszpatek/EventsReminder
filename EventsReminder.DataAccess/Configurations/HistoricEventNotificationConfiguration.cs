using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventsReminder.DataAccess.Configurations
{
    class HistoricEventNotificationConfiguration : IEntityTypeConfiguration<HistoricEventNotification>
    {
        public void Configure(EntityTypeBuilder<HistoricEventNotification> builder)
        {
            builder
                .Property(n => n.HistoricEventDate)
                .IsRequired()
                .HasColumnType("Date");
        }
    }
}
