using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Ncma.Api2 {
    using System.IdentityModel.Tokens.Jwt;
    using System.Text;
    using Core.Members;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;
    using Repository.EFCore;
    using Repository.Models;

    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }
        public IHostingEnvironment HostingEnvironment { get; }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices (IServiceCollection services) {
            services.AddCors ();

            services.AddSingleton<IConfiguration> (Configuration);
            services.AddDbContext<NcmaContext> (options =>
                options.UseSqlServer (Configuration.GetConnectionString ("LiveConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole> ()
                .AddEntityFrameworkStores<NcmaContext> ()
                .AddDefaultTokenProviders ();

            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear (); // => remove default claims

            services
                .AddAuthentication (options => {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer (cfg => {
                    cfg.RequireHttpsMetadata = false;
                    cfg.SaveToken = true;
                    cfg.TokenValidationParameters = new TokenValidationParameters {
                        ValidIssuer = Configuration["JwtIssuer"],
                        ValidAudience = Configuration["JwtIssuer"],
                        IssuerSigningKey = new SymmetricSecurityKey (Encoding.UTF8.GetBytes (Configuration["JwtKey"])),
                        ClockSkew = TimeSpan.Zero // remove delay of token when expire
                    };
                });

            services.AddMvc ();

            //DI
            services.AddScoped<IMemberRepository, MemberRepository> ();
            services.AddTransient<IMemberService, MemberService> ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env, NcmaContext dbContext) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }

            app.UseCors (builder =>
                builder.AllowAnyOrigin ()
                .AllowAnyHeader ()
                .AllowAnyMethod ());

            app.UseAuthentication();

            app.UseMvc ();

            dbContext.Database.EnsureCreated ();

            app.Run (async (context) => {
                await context.Response.WriteAsync ("MVC did not find anything");
            });
        }
    }
}