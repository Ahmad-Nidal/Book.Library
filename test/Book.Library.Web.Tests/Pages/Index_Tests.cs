using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Book.Library.Pages;

public class Index_Tests : LibraryWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
