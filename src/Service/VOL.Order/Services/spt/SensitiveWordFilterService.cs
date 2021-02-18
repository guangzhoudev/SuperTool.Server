/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下SensitiveWordFilterService与ISensitiveWordFilterService中编写
 */
using VOL.Order.IRepositories;
using VOL.Order.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Order.Services
{
    public partial class SensitiveWordFilterService : ServiceBase<SensitiveWordFilter, ISensitiveWordFilterRepository>
    , ISensitiveWordFilterService, IDependency
    {
    public SensitiveWordFilterService(ISensitiveWordFilterRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static ISensitiveWordFilterService Instance
    {
      get { return AutofacContainerModule.GetService<ISensitiveWordFilterService>(); } }
    }
 }
