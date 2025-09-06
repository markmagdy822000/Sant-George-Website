﻿using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Sant_George_Website.Controllers;
using Sant_George_Website.Mappers;
using Sant_George_Website.UnitOfWorks;
using SantGeorgeWebsite.Models;

namespace SantGeorgeWebsite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddDbContext<SantGeorgeWebsiteDBContext>(options =>
                options.UseLazyLoadingProxies()
                       .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

            // ✅ JWT Authentication setup with standard "Bearer" scheme
            var jwtKey = "this is my secrect key for the SantGeorge project";
            var key = Encoding.ASCII.GetBytes(jwtKey);

            //builder.Services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //.AddJwtBearer(options =>
            //{
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        IssuerSigningKey = new SymmetricSecurityKey(key),
            //        ValidateIssuer = false,
            //        ValidateAudience = false,
            //        ValidateLifetime = true,
            //        ValidateIssuerSigningKey = true
            //    };
            //});

           


             // Identity
             builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedEmail = true;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredLength = 1;
            })
            .AddEntityFrameworkStores<SantGeorgeWebsiteDBContext>()
            .AddDefaultTokenProviders();
            
            builder.Services.Configure<DataProtectionTokenProviderOptions>(o =>
                o.TokenLifespan = TimeSpan.FromHours(2));

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultScheme = "myschema";
                options.DefaultAuthenticateScheme = "myschema";
                options.DefaultChallengeScheme = "myschema";
            })
        .AddJwtBearer("myschema", options =>
        {
            var secretKey = new SymmetricSecurityKey(key);
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                IssuerSigningKey = secretKey,
                ValidateLifetime = true
            };
        });

            // Other services
            builder.Services.AddOpenApi();
            builder.Services.AddAutoMapper(cfg => cfg.AddProfile<MappingConfig>());
            builder.Services.AddTransient<IEmailSender, ConfirmEmailController>();
            builder.Services.AddScoped<IUnitOfWorks, UnitOfWorks>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.MapOpenApi();
            }

            app.UseRouting();

            // ✅ Authentication + Authorization
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
            app.Run();
        }
    }
}
