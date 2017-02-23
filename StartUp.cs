using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using TodoApp.DataAccess;
namespace TodoApp
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        
            services.AddSingleton<ITasksRepository,TasksRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvcWithDefaultRoute();
            
        }
    }
}