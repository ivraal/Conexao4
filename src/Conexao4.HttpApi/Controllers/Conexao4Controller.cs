using Conexao4.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Conexao4.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Conexao4Controller : AbpControllerBase
{
    protected Conexao4Controller()
    {
        LocalizationResource = typeof(Conexao4Resource);
    }
}
