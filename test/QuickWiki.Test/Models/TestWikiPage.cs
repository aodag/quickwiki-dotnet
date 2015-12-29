using Xunit;
using QuickWiki.Models;

namespace QuickWiki.Test.Models
{
    public class TestWikiPage
    {
        [Fact]
        public void HtmlContent()
        {
            var target = new WikiPage() {Content = "# this is"};
            Assert.Equal("<h1>this is</h1>\n\n", target.ConvertedText);
        }
    }
}
