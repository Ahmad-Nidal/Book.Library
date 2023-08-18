using System;
using System.Collections.Generic;
using System.Text;
using Book.Library.Localization;
using Volo.Abp.Application.Services;

namespace Book.Library;

/* Inherit your application services from this class.
 */
public abstract class LibraryAppService : ApplicationService
{
    protected LibraryAppService()
    {
        LocalizationResource = typeof(LibraryResource);
    }
}
