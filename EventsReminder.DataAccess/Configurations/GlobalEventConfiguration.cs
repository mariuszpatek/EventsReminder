using Microsoft.EntityFrameworkCore;
using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventsReminder.DataAccess.Configurations
{
    class GlobalEventConfiguration : IEntityTypeConfiguration<GlobalEvent>
    {
        public void Configure(EntityTypeBuilder<GlobalEvent> builder)
        {
            builder
                .ToTable("GlobalEvents");
            builder
                .HasKey(m => m.GlobalEventId);
            builder
                .Property(m => m.Content)
                .IsRequired()
                .HasMaxLength(3000);
            builder
                .Property(m => m.DateTime)
                .IsRequired()
                .HasColumnType("Date"); ;
        }
    }
}
