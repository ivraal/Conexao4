using Conexao4.Data;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace Conexao4.Idp.Web
{
    public class SeedInMemoryHostedService : IHostedService
    {
        private readonly Conexao4DbMigrationService _idpDbMigrationService;

        public SeedInMemoryHostedService(
            Conexao4DbMigrationService idpDbMigrationService)
        {
            _idpDbMigrationService = idpDbMigrationService;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await _idpDbMigrationService.SeedDataAsync();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
