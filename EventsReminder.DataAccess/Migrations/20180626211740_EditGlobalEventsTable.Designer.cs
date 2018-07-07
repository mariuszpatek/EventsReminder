﻿// <auto-generated />
using System;
using EventsReminder.Common.Enums;
using EventsReminder.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventsReminder.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180626211740_EditGlobalEventsTable")]
    partial class EditGlobalEventsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventsReminder.Model.Models.AheadOfTime", b =>
                {
                    b.Property<int>("AheadOfTimeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("NumberOfDays");

                    b.HasKey("AheadOfTimeId");

                    b.ToTable("AheadOfTime");

                    b.HasData(
                        new { AheadOfTimeId = 1, Name = "Tego samego dnia", NumberOfDays = 0 },
                        new { AheadOfTimeId = 2, Name = "Jeden dzień wcześniej", NumberOfDays = 1 },
                        new { AheadOfTimeId = 3, Name = "Dwa dni wcześniej", NumberOfDays = 2 },
                        new { AheadOfTimeId = 4, Name = "Trzy dni wcześniej", NumberOfDays = 3 },
                        new { AheadOfTimeId = 5, Name = "Tydzień wcześniej", NumberOfDays = 7 }
                    );
                });

            modelBuilder.Entity("EventsReminder.Model.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("EventsReminder.Model.Models.DayOfWeek", b =>
                {
                    b.Property<int>("DayOfWeekId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("DayOfWeekId");

                    b.ToTable("DaysOfWeek");

                    b.HasData(
                        new { DayOfWeekId = 0, Name = "Niedziela" },
                        new { DayOfWeekId = 1, Name = "Poniedziałek" },
                        new { DayOfWeekId = 2, Name = "Wtorek" },
                        new { DayOfWeekId = 3, Name = "Środa" },
                        new { DayOfWeekId = 4, Name = "Czwartek" },
                        new { DayOfWeekId = 5, Name = "Piątek" },
                        new { DayOfWeekId = 6, Name = "Sobota" }
                    );
                });

            modelBuilder.Entity("EventsReminder.Model.Models.DaysOfWeekWhenSendNotification", b =>
                {
                    b.Property<int>("DaysOfWeekWhenSendNotificationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DayOfWeekId");

                    b.Property<int>("NotificationId");

                    b.HasKey("DaysOfWeekWhenSendNotificationId");

                    b.HasIndex("DayOfWeekId");

                    b.HasIndex("NotificationId");

                    b.ToTable("DaysOfWeekWhenSendNotification");
                });

            modelBuilder.Entity("EventsReminder.Model.Models.GlobalEvent", b =>
                {
                    b.Property<int>("GlobalEventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(3000);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("Date");

                    b.HasKey("GlobalEventId");

                    b.ToTable("GlobalEvents");
                });

            modelBuilder.Entity("EventsReminder.Model.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<DateTime?>("DateOfSending");

                    b.Property<int>("NotificationId");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("UserEmail");

                    b.HasKey("MessageId");

                    b.HasIndex("NotificationId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("EventsReminder.Model.Models.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedUtc")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetUtcDate()");

                    b.Property<DateTime?>("DateOfLastDispatch");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("MessageType")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("NotificationType")
                        .IsRequired();

                    b.Property<byte>("SendingHour");

                    b.Property<string>("UserId");

                    b.HasKey("NotificationId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");

                    b.HasDiscriminator<string>("NotificationType");
                });

            modelBuilder.Entity("EventsReminder.Model.Models.SendNotificationAheadOfTime", b =>
                {
                    b.Property<int>("SendNotificationAheadOfTimeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AheadOfTimeId");

                    b.Property<int>("NotificationId");

                    b.HasKey("SendNotificationAheadOfTimeId");

                    b.HasIndex("AheadOfTimeId");

                    b.HasIndex("NotificationId");

                    b.ToTable("SendNotificationsAheadOfTime");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EventsReminder.Model.Models.HistoricEventNotification", b =>
                {
                    b.HasBaseType("EventsReminder.Model.Models.Notification");

                    b.Property<DateTime>("HistoricEventDate")
                        .HasColumnType("Date");

                    b.ToTable("HistoricEventNotification");

                    b.HasDiscriminator().HasValue("HistoricEvent");
                });

            modelBuilder.Entity("EventsReminder.Model.Models.OneTimeEventNotification", b =>
                {
                    b.HasBaseType("EventsReminder.Model.Models.Notification");

                    b.Property<DateTime>("FutureEventDate")
                        .HasColumnType("Date");

                    b.ToTable("OneTimeEventNotification");

                    b.HasDiscriminator().HasValue("OneTimeEvent");
                });

            modelBuilder.Entity("EventsReminder.Model.Models.PeriodicEventNotification", b =>
                {
                    b.HasBaseType("EventsReminder.Model.Models.Notification");


                    b.ToTable("PeriodicEventNotification");

                    b.HasDiscriminator().HasValue("PeriodicEvent");
                });

            modelBuilder.Entity("EventsReminder.Model.Models.DaysOfWeekWhenSendNotification", b =>
                {
                    b.HasOne("EventsReminder.Model.Models.DayOfWeek", "DayOfWeek")
                        .WithMany("DaysOfWeekWhenSendNotification")
                        .HasForeignKey("DayOfWeekId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventsReminder.Model.Models.PeriodicEventNotification", "Notification")
                        .WithMany("DaysOfWeekWhenSendNotification")
                        .HasForeignKey("NotificationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EventsReminder.Model.Models.Message", b =>
                {
                    b.HasOne("EventsReminder.Model.Models.Notification", "Notification")
                        .WithMany("Messages")
                        .HasForeignKey("NotificationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EventsReminder.Model.Models.Notification", b =>
                {
                    b.HasOne("EventsReminder.Model.Models.ApplicationUser", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EventsReminder.Model.Models.SendNotificationAheadOfTime", b =>
                {
                    b.HasOne("EventsReminder.Model.Models.AheadOfTime", "AheadOfTime")
                        .WithMany("SendNotificationAheadOfTime")
                        .HasForeignKey("AheadOfTimeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventsReminder.Model.Models.Notification", "Notification")
                        .WithMany("SendNotificationAheadOfTime")
                        .HasForeignKey("NotificationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EventsReminder.Model.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EventsReminder.Model.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventsReminder.Model.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EventsReminder.Model.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
