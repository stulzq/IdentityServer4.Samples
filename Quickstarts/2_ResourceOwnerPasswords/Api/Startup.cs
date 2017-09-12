using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
	        services.AddMvcCore().AddJsonFormatters();

			#region use IdentityServer4.AccessTokenValidation

			services
				.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
		        .AddIdentityServerAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme, (option) =>
		        {
			        option.Authority = "http://localhost:5000";
			        option.RequireHttpsMetadata = false;
			        option.ApiName = "api1";
		        });

	        #endregion

			#region use Microsoft.AspNetCore.Authentication.JwtBearer

			/*services.AddAuthentication((options) =>
		        {
			        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
			        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
		        })
		        .AddJwtBearer(options =>
		        {
			        options.TokenValidationParameters = new TokenValidationParameters();
			        options.RequireHttpsMetadata = false;
			        options.Audience = "api1";//api范围
			        options.Authority = "http://localhost:5000";//IdentityServer地址
		        });*/

			#endregion
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			app.UseAuthentication();

			app.Use((context, next) =>
			{
				var user = context.User;

				context.Response.StatusCode = user.Identity.IsAuthenticated ? 200 : 401;

				return next.Invoke();
			});
			app.UseMvc();
        }
    }
}
