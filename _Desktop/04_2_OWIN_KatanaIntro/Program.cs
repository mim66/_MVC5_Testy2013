using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_2_OWIN_KatanaIntro
{

	using System.IO;
	using AppFunc = Func<IDictionary<string, object>, Task>;

	class Program
	{
		static void Main(string[] args)
		{
			//Install package:
			//Install-Package -IncludePrerelease microsoft.owin.hosting
			//Install-Package -IncludePrerelease microsoft.owin.host.httpListener

			string uri = "http://localhost:8080";
			using (WebApp.Start<Startup>(uri))
			{
				Console.WriteLine("Started!");
				Console.ReadKey();
				Console.WriteLine("Stopping!");
			};
			// run this
			// on browser you run uri: localhost:8080
			// and stop program by consoleAppplication by press key

			/// Step 2
			//Install-Package -IncludePrerelease microsoft.owin.Diagnostics

			/// Step 6
			//Install-Package -IncludePrerelease microsoft.AspNet.WebAPI.OwinSelfHost
		}
	}
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			#region 
			/// Step 1
			//app.Run(ctx =>
			//{
			//	return ctx.Response.WriteAsync("Hello World");
			//});

			/// Step 2
			//app.UseWelcomePage();

			/// Step 3
			//app.Use<HelloWorldComponent>();

			/// Step 4
			//app.UseHelloWorld();
			#endregion

			/// Step 5
			//app.Use(async (enviroment, next) =>
			//{ 
			//	foreach(var pair in enviroment.Environment)
			//	{
			//		Console.WriteLine("{0}:{1}", pair.Key, pair.Value);
			//	}
			//	await next();
			//});

			app.Use(async (environment, next) =>
			{
				Console.WriteLine("Requesting: " + environment.Request.Path);

				await next();

				Console.WriteLine("Response: " + environment.Response.StatusCode);
			});

			app.UseHelloWorld();
		}
	}

	public static class AppBulderExtension 
	{
		public static void UseHelloWorld(this IAppBuilder app)
		{
			 app.Use<HelloWorldComponent>();
		}	
	}

	/// Step 3
	public class HelloWorldComponent 
	{
		AppFunc _next;
		public HelloWorldComponent(AppFunc next)
		{
			_next = next;
		}

		public Task Invoke(IDictionary<string, object> enviroment)
		{
			var response = enviroment["owin.ResponseBody"] as Stream;
			using (var writer = new StreamWriter(response))
			{
				return writer.WriteAsync("Hello!");
			}
		}
	}




}
