using Conexao4.Localization;
using Volo.Abp.Application.Services;

namespace Conexao4;

/* Inherit your application services from this class.
 */
public abstract class Conexao4AppService : ApplicationService
{
    protected Conexao4AppService()
    {
        LocalizationResource = typeof(Conexao4Resource);
    }
}
