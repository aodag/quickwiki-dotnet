using Microsoft.Data.Entity;

namespace QuickWiki.Models
{
    public class WikiPageDbContext: DbContext
    {
        public DbSet<WikiPage> WikiPages
        {
            get; set;
        }
    }
}
