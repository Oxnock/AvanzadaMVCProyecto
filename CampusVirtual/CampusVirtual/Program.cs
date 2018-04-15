using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CampusVirtual.Model;
using CampusVirtual.Model.Entities;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CampusVirtual
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = BuildWebHost(args);
			using (var scope = host.Services.CreateScope())
			{
				var services = scope.ServiceProvider;
				CampusContext context = services.GetRequiredService<CampusContext>();
				UserManager<Usuario> userManager = services.GetRequiredService<UserManager<Usuario>>();
				RoleManager<IdentityRole> roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
				CampusVirtualInitializer.Seed(context, userManager, roleManager);
			}
			host.Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.Build();
	}
}