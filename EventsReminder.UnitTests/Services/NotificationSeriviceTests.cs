using EventsReminder.DataAccess;
using EventsReminder.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace EventsReminder.UnitTests.Services
{
    [TestFixture]
    public class NotificationSeriviceTests
    {
        private INotificationRepository _notificationRepository;
        private ApplicationDbContext _context;

        [SetUp]
        public void SetUp()
        {
            DbContextOptions<ApplicationDbContext> options;
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseInMemoryDatabase("TestDb");
            options = builder.Options;
            _context = new ApplicationDbContext(options);
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            _notificationRepository = new NotificationRepository(_context);
        }


    }
}
