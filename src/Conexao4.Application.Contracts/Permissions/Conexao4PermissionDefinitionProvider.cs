using Conexao4.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Conexao4.Permissions;

public class Conexao4PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Conexao4Permissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(Conexao4Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Conexao4Resource>(name);
    }
}
