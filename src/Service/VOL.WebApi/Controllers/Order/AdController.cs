/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹AdController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Order.IServices;
namespace VOL.Order.Controllers
{
    [Route("api/Ad")]
    [PermissionTable(Name = "Ad")]
    public partial class AdController : ApiBaseController<IAdService>
    {
        public AdController(IAdService service)
        : base(service)
        {
        }
    }
}

