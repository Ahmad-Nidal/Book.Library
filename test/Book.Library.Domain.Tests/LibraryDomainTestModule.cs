using Book.Library.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Book.Library;

[DependsOn(
    typeof(LibraryEntityFrameworkCoreTestModule)
    )]
public class LibraryDomainTestModule : AbpModule
{

}
