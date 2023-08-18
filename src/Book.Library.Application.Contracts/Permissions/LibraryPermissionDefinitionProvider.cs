using Book.Library.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Book.Library.Permissions;

public class LibraryPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LibraryPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(LibraryPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LibraryResource>(name);
    }
}
