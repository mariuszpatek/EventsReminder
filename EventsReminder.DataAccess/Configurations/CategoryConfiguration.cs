using EventsReminder.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventsReminder.DataAccess.Configurations
{
    public class CategoryConfiguration
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .ToTable("Categories");
            builder
                .HasKey(m => m.CategoryId);
            builder
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
