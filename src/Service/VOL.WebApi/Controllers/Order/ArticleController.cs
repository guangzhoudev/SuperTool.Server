/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹ArticleController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Order.IServices;
namespace VOL.Order.Controllers
{
    [Route("api/Article")]
    [PermissionTable(Name = "Article")]
    public partial class ArticleController : ApiBaseController<IArticleService>
    {
        public ArticleController(IArticleService service)
        : base(service)
        {
        }
    }
}

