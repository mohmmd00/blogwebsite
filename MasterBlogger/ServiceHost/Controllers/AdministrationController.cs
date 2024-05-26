using MB.Application.Contacts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace ServiceHost.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly IArticleCategoryApplication _application;

        public AdministrationController(IArticleCategoryApplication application)
        {
            _application = application;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ArticleCategoryList()
        {
            var ArticleCategoryToList = _application.ToViewModelList();
            return View(ArticleCategoryToList);
        }
        public IActionResult CreateNewArticleCategory()
        {
            return View();
        }

        public IActionResult FuncCreatedArticleCategory(CreateArticleCategory Command)
        {
             _application.Create(Command);
            return View("Index");
        }
        [HttpGet]
        public IActionResult EditArticleCategory(long id)
        {
            var chosenArticleCategory = _application.fetchArticleCategoryFromDatabaseForEditBy(id);
            return View(chosenArticleCategory);
        }

        public IActionResult FuncEditedArticleCategory(RenameArticleCategory Command)
        {
            _application.Rename(Command);
            return View("Index");
        }
    }
}
