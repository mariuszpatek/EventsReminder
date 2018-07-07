using EventsReminder.DataAccess.Configurations;
using EventsReminder.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace EventsReminder.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly ILoggerFactory _loggerFactory;

        public DbSet<Message> Messages { get; set; }
        public DbSet<Model.Models.DayOfWeek> DaysOfWeek { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<AheadOfTime> AheadOfTime { get; set; }
        public DbSet<DaysOfWeekWhenSendNotification> DaysOfWeekWhenSendNotification { get; set; }
        public DbSet<SendNotificationAheadOfTime> SendNotificationsAheadOfTime { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NotificationCategory> NotificationsCategories { get; set; }
        public DbSet<GlobalEvent> GlobalEvents { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ILoggerFactory loggerFactory)
        : base(options)
        {
            _loggerFactory = loggerFactory;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLoggerFactory(_loggerFactory);
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new GlobalEventConfiguration());
            builder.ApplyConfiguration(new DayOfWeekConfiguration());
            builder.ApplyConfiguration(new NotificationConfiguration());
            builder.ApplyConfiguration(new MessageConfiguration());
            builder.ApplyConfiguration(new AheadOfTimeConfiguration());
            builder.ApplyConfiguration(new OneTimeEventNotificationConfiguration());
            builder.ApplyConfiguration(new HistoricEventNotificationConfiguration());
            builder.ApplyConfiguration(new SendNotificationAheadOfTimeConfiguration());
            base.OnModelCreating(builder);
        }

        public static async Task CreateAdminAccountAndRole(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            UserManager<ApplicationUser> userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string email = configuration["Data:AdminUser:Email"];
            string password = configuration["Data:AdminUser:Password"];
            string role = configuration["Data:AdminUser:Role"];

            if (await roleManager.FindByNameAsync(role) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }

            if (await userManager.FindByEmailAsync(email) == null)
            {
                var adminUser = new ApplicationUser
                {
                    Email = email,
                    UserName = email
                };

                var result = await userManager.CreateAsync(adminUser, password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, role);               
                }
            }
            else
            {
                var user = await userManager.FindByNameAsync(email);
                if (!await userManager.IsInRoleAsync(user, role))
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
        }
    }
}
