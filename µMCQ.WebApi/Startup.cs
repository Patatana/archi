using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MediatR;
using MicroServiceMCQ.Application.Interfaces;
using MicroServiceMCQ.Application.QuestionTypeManage.Queries.GetQuestionType;
using MicroServiceMCQ.Application.QuestionTypeManage.Queries.GetQuestionTypesList;
using MicroServiceMCQ.Infrastructure;
using MicroServiceMCQ.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MicroServiceMCQ.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddTransient<INotificationService, NotificationService>();


            services.AddDbContext<MicroServiceMCQDbContext>(opt =>
                opt.UseSqlServer("Data Source=localhost;Initial Catalog=testArchi;User ID=jean;Password=neymar")
                );


            //rajouter la ligne pour le faire par reflexion

            services.AddMediatR(typeof(GetQuestionTypesListQueryHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(GetQuestionTypeQueryHandler).GetTypeInfo().Assembly);
            services.AddSwaggerDocument();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseHttpsRedirection();
            app.UseMvc();

        }
    }
}
