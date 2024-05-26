using MB.Application;
using MB.Application.Contacts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.EFCore;
using MB.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure
{
    public class Bootstrapper
    {
        public static void Config(IServiceCollection service, string connectionstring)
        {
            service.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            service.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();

            service.AddDbContext<MasterBloggerContext>(options=> options.UseSqlServer(connectionstring));
        }

    }
}
