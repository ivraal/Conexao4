using Microsoft.Extensions.Localization;
using Conexao4.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Conexao4.Blazor;

[Dependency(ReplaceServices = true)]
public class Conexao4BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<Conexao4Resource> _localizer;

    public Conexao4BrandingProvider(IStringLocalizer<Conexao4Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
