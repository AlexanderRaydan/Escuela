using System;
using Escuela.Areas.Identity.Data;
using Escuela.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Escuela.Areas.Identity.IdentityHostingStartup))]
namespace Escuela.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EscuelaContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EscuelaContextConnection")));

                services.AddDefaultIdentity<EscuelaUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<EscuelaContext>();
            });
        }
    }
}