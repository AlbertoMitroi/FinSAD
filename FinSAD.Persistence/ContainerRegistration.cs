using FinSAD.Domain.Interfaces;
using FinSAD.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FinSAD.Persistence
{
    public static class ContainerRegistration
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICardRepository, CardRepository>();
        }
    }
}
