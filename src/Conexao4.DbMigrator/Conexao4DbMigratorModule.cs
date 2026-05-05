using Conexao4.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Conexao4.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Conexao4EntityFrameworkCoreModule),
    typeof(Conexao4ApplicationContractsModule)
)]
public class Conexao4DbMigratorModule : AbpModule
{
}
