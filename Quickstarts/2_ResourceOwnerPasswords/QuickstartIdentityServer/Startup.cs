using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace QuickstartIdentityServer
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
	        // 使用内存存储，密钥，客户端和资源来配置身份服务器。
			services.AddIdentityServer()
				.AddDeveloperSigningCredential()
		        .AddInMemoryApiResources(Config.GetApiResources())
		        .AddInMemoryClients(Config.GetClients())
				.AddTestUsers(Config.GetUsers()); ;
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,ILoggerFactory loggerFactory)
        {

			loggerFactory.AddConsole(LogLevel.Debug);
	        app.UseDeveloperExceptionPage();

	        app.UseIdentityServer();

			app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
