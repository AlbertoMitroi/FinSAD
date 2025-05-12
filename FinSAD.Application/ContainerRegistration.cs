using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FinSAD.Application
{
    public static class ContainerRegistration
    {
        public static void RegisterApplication(this IServiceCollection services)
        {
            services.RegisterMediator();
        }

        private static void RegisterMediator(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });
        }
    }
}
