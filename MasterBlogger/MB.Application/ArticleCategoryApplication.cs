using System.ComponentModel;
using System.Globalization;
using MB.Application.Contacts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _repository;

        public ArticleCategoryApplication(IArticleCategoryRepository repository)
        {
            _repository = repository;
        }

        public List<ArticleCategoryViewModel> ToViewModelList()
        {
            var ArticleCategories = _repository.GetAll();
            var Result = new List<ArticleCategoryViewModel>();
            foreach (var ArticleCategory in ArticleCategories)
            {
                Result.Add(new ArticleCategoryViewModel
                {
                    Id = ArticleCategory.Id,
                    Title = ArticleCategory.Title,
                    IsDeleted = ArticleCategory.IsDeleted,
                    CreationDate = ArticleCategory.CreationDate.ToString(CultureInfo.InvariantCulture)

                });
            }
            return Result;
        }

        public void Create(CreateArticleCategory Command)
        {
            var NewArticleCategory = new ArticleCategory(Command.Title);

            _repository.Create(NewArticleCategory);
            _repository.Save();

        }

        public void Rename(RenameArticleCategory Command)
        {
            var ChosenArticleCategory = _repository.GetBy(Command.Id);

            ChosenArticleCategory.Rename(Command.Title);
            _repository.Save();
        }
        public RenameArticleCategory fetchArticleCategoryFromDatabaseForEditBy(long id)
        {
            var ChosenArticleCategory = _repository.GetBy(id);
            return new RenameArticleCategory
            {
                Id = ChosenArticleCategory.Id,
                Title = ChosenArticleCategory.Title
            };
        }
    }
}
