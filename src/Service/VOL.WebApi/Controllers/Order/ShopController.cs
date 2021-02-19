/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹ShopController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Order.IServices;
namespace VOL.Order.Controllers
{
    [Route("api/Shop")]
    [PermissionTable(Name = "Shop")]
    public partial class ShopController : ApiBaseController<IShopService>
    {
        public ShopController(IShopService service)
        : base(service)
        {
        }
    }
}

