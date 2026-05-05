using System.Threading.Tasks;

namespace Conexao4.Data;

public interface IConexao4DbSchemaMigrator
{
    Task MigrateAsync();
}
