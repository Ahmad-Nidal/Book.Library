using Book.Library.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Book.Library.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LibraryEntityFrameworkCoreModule),
    typeof(LibraryApplicationContractsModule)
    )]
public class LibraryDbMigratorModule : AbpModule
{
}
