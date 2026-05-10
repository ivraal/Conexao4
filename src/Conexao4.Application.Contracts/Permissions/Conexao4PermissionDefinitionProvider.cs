using Conexao4.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Conexao4.Permissions;

public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var bookStoreGroup = context.AddGroup(Conexao4Permissions.GroupName, L("Permission:Conexao4"));

        //Produtos permissions
        var produtosPermission = bookStoreGroup.AddPermission(Conexao4Permissions.Produtos.Default, L("Permission:Produtos"));
        produtosPermission.AddChild(Conexao4Permissions.Produtos.Create, L("Permission:Produtos.Create"));
        produtosPermission.AddChild(Conexao4Permissions.Produtos.Edit, L("Permission:Produtos.Edit"));
        produtosPermission.AddChild(Conexao4Permissions.Produtos.Delete, L("Permission:Produtos .Delete"));
    }

    private static LocalizableString L(string nome)
    {
        return LocalizableString.Create<Conexao4Resource>(nome);
    }
}