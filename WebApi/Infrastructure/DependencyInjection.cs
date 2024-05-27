﻿using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IKnightRepository, KnightRepository>();

            services.AddDbContext<KnightsContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("KnightsConnection"));
            });

            return services;
        }
    }
}
