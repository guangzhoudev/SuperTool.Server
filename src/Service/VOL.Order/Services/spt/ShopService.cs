/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下ShopService与IShopService中编写
 */
using VOL.Order.IRepositories;
using VOL.Order.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Order.Services
{
    public partial class ShopService : ServiceBase<Shop, IShopRepository>
    , IShopService, IDependency
    {
    public ShopService(IShopRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IShopService Instance
    {
      get { return AutofacContainerModule.GetService<IShopService>(); } }
    }
 }
