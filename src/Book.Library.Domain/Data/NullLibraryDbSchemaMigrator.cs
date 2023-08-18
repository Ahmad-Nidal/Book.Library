using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Book.Library.Data;

/* This is used if database provider does't define
 * ILibraryDbSchemaMigrator implementation.
 */
public class NullLibraryDbSchemaMigrator : ILibraryDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
