namespace Conexao4.Permissions;


public static class Conexao4Permissions
{
    public const string GroupName = "Conexao4";

    // other permissions...
    // other permissions...

    // *** ADDED a NEW NESTED CLASS ***
    public static class Produtos
    {
        public const string Default = GroupName + ".Produtos";
        public const string Create = Default + ".Criar";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}

//Add your own permission names. Example:
//public const string MyPermission1 = GroupName + ".MyPermission1";