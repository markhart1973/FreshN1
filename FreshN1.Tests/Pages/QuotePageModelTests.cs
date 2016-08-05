using FreshN1.PageModels;
using Xunit;

namespace FreshN1.Tests.Pages
{
    public class QuotePageModelTests
    {
        [Fact]
        public void QuotePageModel_Ctor_Instantiation_ReturnsInstance()
        {
            Assert.NotNull(new QuotePageModel());
        }
    }
}