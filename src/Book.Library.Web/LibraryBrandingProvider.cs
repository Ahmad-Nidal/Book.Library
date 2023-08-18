using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Book.Library.Web;

[Dependency(ReplaceServices = true)]
public class LibraryBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Library";
}
