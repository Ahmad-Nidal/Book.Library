using Book.Library.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Book.Library.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class LibraryPageModel : AbpPageModel
{
    protected LibraryPageModel()
    {
        LocalizationResourceType = typeof(LibraryResource);
    }
}
