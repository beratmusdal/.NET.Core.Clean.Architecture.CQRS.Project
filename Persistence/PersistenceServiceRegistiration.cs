﻿using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence;

public static class PersistenceServiceRegistiration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddDbContext<BaseDbContext>(options => options.UseInMemoryDatabase("nArchitecture"));
        services.AddDbContext<BaseDbContext>(options => options.UseSqlServer("RentACarCourseDb"));




        services.AddScoped<IModelRepository, ModelRepository>();
        services.AddScoped<IBrandRepository, BrandRepository>();
        return services;
    }
}
