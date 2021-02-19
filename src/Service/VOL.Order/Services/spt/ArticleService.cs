/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下ArticleService与IArticleService中编写
 */
using VOL.Order.IRepositories;
using VOL.Order.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Order.Services
{
    public partial class ArticleService : ServiceBase<Article, IArticleRepository>
    , IArticleService, IDependency
    {
    public ArticleService(IArticleRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IArticleService Instance
    {
      get { return AutofacContainerModule.GetService<IArticleService>(); } }
    }
 }
