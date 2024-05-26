namespace MB.Application.Contacts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> ToViewModelList();
        void Create(CreateArticleCategory Command);
        void Rename(RenameArticleCategory Command);

        RenameArticleCategory fetchArticleCategoryFromDatabaseForEditBy(long id);
    }
}
