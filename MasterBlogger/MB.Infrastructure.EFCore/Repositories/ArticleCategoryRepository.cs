
using MB.Domain.ArticleCategoryAgg;

namespace MB.Infrastructure.EFCore.Repository
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly MasterBloggerContext _context;

        public ArticleCategoryRepository(MasterBloggerContext context)
        {
            _context = context;
        }


        public void Create(ArticleCategory entity)
        {
            _context.ArticleCategories.Add(entity);

        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public List<ArticleCategory> GetAll()
        {
            return _context.ArticleCategories.ToList();
        }

        public ArticleCategory GetBy(long id)
        {
            return _context.ArticleCategories.FirstOrDefault(x => x.Id == id);
        }

    }
}
