using Microsoft.Extensions.DependencyInjection;
using MigrationExample.FluentMigrator;

namespace MigrationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = FluentMigratorHelper.CreateServices();

            using (var scope = serviceProvider.CreateScope())
            {
                FluentMigratorHelper.UpdateDatabase(scope.ServiceProvider);
            }
        }
    }
}
