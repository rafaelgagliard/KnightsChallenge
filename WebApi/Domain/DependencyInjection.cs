using Domain.Entities;
using Domain.Validations;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IValidator<Knight>, KnightsValidations>();

            return services;
        }
    }
}
