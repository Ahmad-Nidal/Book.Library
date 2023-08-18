using Volo.Abp.Modularity;

namespace Book.Library;

[DependsOn(
    typeof(LibraryApplicationModule),
    typeof(LibraryDomainTestModule)
    )]
public class LibraryApplicationTestModule : AbpModule
{

}
