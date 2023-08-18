using System.Threading.Tasks;

namespace Book.Library.Data;

public interface ILibraryDbSchemaMigrator
{
    Task MigrateAsync();
}
