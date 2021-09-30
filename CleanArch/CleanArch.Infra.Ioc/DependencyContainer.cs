using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection service)
        {
            //Domain InMemoryBus MediatR
            service.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handler
            service.AddScoped<IRequestHandler<CreateCrsssCommand, bool>, CrsssCommandHandler>();

            //Application Layer
           // service.AddScoped<ICourseService, CourseService>();

            service.AddScoped<ICrsssService, CrsssService>();


            //Infra.Data Layer
            //service.AddScoped<ICourseRepository, CourseRepository>();
            service.AddScoped<ICrsssRepository, CrsssRepository>();
            service.AddScoped<UniversityDbContext>();
        }
    }
}
