using AutoMapper;
using EventsReminder.BusinessLogic;
using EventsReminder.BusinessLogic.KeyPhrases;
using EventsReminder.DataAccess;
using EventsReminder.DataAccess.Repositories;
using EventsReminder.Model.Models;
using EventsReminder.Model.ViewModels.Account;
using EventsReminder.Web.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EventsReminder.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IHostingEnvironment _env { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            _env = env;
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication()
                .AddGoogle(options => {
                    options.ClientId = Configuration["Data:GoogleAuth:ClientId"];
                    options.ClientSecret = Configuration["Data:GoogleAuth:ClientSecret"];
                })
                .AddJwtBearer(cfg =>
                {
                    cfg.RequireHttpsMetadata = false;
                    cfg.SaveToken = true;

                    cfg.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ClockSkew = TimeSpan.FromMinutes(3),
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        RequireExpirationTime = true,
                        ValidateLifetime = true,
                        ValidIssuer = Configuration["Data:Token:Issuer"],
                        ValidAudience = Configuration["Data:Token:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Data:Token:Key"]))
                    };

                });

            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(o => {
                o.Tokens.ChangeEmailTokenProvider = "Phone";
            })
            .AddErrorDescriber<CustomIdentityErrorDescriber>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            services.AddScoped<IPopulateService, PopulateService>();
            services.AddScoped<IAheadOfTimeValuesRepository, AheadOfTimeValuesRepository>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IGlobalEventRepository, GlobalEventRepository>();
            services.AddScoped<IGlobalEventService, GlobalEventService>();
            services.AddScoped<IKeyPhrasesAnalyzer, KeyPhrasesAnalyzer>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICalendarService, CalendarService>();
            services.AddScoped<ISmsService, SmsService>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 6;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 7;
                options.Lockout.AllowedForNewUsers = true;

                options.User.RequireUniqueEmail = true;
            });

            services.AddAutoMapper();

            services.AddSession();
            services.AddMvc()
                .AddViewLocalization()
                .AddDataAnnotationsLocalization();

            if (!_env.IsDevelopment())
            {
                services.Configure<MvcOptions>(o =>
                    o.Filters.Add(new RequireHttpsAttribute()));
            }

            services.Configure<RequestLocalizationOptions>(
                opts =>
                {
                    var supportedCultures = new List<CultureInfo> { new CultureInfo("pl-PL") };

                    opts.DefaultRequestCulture = new RequestCulture("pl-PL");
                    opts.SupportedCultures = supportedCultures;
                    opts.SupportedUICultures = supportedCultures;
                });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddApplicationInsights(app.ApplicationServices, LogLevel.Information);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
                app.UseMiddleware<ExceptionHandlerMiddleware>();
            }
            else
            {
                app.UseExceptionHandler("/Error");     
                app.UseMiddleware<ExceptionHandlerMiddleware>();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRequestLocalization();       
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            ApplicationDbContext.CreateAdminAccountAndRole(app.ApplicationServices, Configuration).Wait();
        }
    }
}
