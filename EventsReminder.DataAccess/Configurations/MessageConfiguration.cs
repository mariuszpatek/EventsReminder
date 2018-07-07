using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventsReminder.DataAccess.Configurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder
                .ToTable("Messages");
            builder
                .HasKey(m => m.MessageId);
            builder
                .Property(m => m.Subject)
                .IsRequired()
                .HasMaxLength(255);
            builder
                .Property(m => m.Body)
                .IsRequired();
        }
    }
}
