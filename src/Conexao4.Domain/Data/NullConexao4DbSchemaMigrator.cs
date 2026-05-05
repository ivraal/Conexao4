using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Conexao4.Data;

/* This is used if database provider does't define
 * IConexao4DbSchemaMigrator implementation.
 */
public class NullConexao4DbSchemaMigrator : IConexao4DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
