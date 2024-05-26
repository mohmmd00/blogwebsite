using MB.Application.Contacts.ArticleCategory;

namespace MB.Domain.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository
    {
        void Create(ArticleCategory entity);
        void Save();

        List<ArticleCategory> GetAll();
        ArticleCategory GetBy(long id);
    }
}
