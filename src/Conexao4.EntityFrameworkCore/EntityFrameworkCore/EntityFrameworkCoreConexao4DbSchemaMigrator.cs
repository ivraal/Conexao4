using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Conexao4.Data;
using Volo.Abp.DependencyInjection;

namespace Conexao4.EntityFrameworkCore;

public class EntityFrameworkCoreConexao4DbSchemaMigrator
    : IConexao4DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreConexao4DbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Conexao4DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Conexao4DbContext>()
            .Database
            .MigrateAsync();
    }
}
