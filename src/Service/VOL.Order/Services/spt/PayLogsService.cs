/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下PayLogsService与IPayLogsService中编写
 */
using VOL.Order.IRepositories;
using VOL.Order.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Order.Services
{
    public partial class PayLogsService : ServiceBase<PayLogs, IPayLogsRepository>
    , IPayLogsService, IDependency
    {
    public PayLogsService(IPayLogsRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IPayLogsService Instance
    {
      get { return AutofacContainerModule.GetService<IPayLogsService>(); } }
    }
 }
