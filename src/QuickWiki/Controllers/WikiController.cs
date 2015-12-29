using Microsoft.AspNet.Mvc;

namespace QuickWiki.Controllers
{
    public class WikiController: Controller
    {
        [FromServices]
        public Models.WikiPageDbContext DbContext
        {
            get; set;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show([FromRoute]string wikiPageName)
        {
            return View();
        }

        public IActionResult Edit([FromRoute]string wikiPageName)
        {
            return View();
        }

        public IActionResult Update([FromRoute]string wikiPageName)
        {
            return View();
        }
    }
}
