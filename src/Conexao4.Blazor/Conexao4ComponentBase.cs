using Conexao4.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Conexao4.Blazor;

public abstract class Conexao4ComponentBase : AbpComponentBase
{
    protected Conexao4ComponentBase()
    {
        LocalizationResource = typeof(Conexao4Resource);
    }
}
