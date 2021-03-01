using VOL.Core.BaseProvider;
using VOL.Core.Utilities;
using VOL.Entity.DomainModels;
using System.Threading.Tasks;

namespace VOL.System.IServices
{
    public partial interface ISys_UserService
    {
        
        Task<WebResponseContent> LoginNotValid(LoginInfo loginInfo);

        Task<WebResponseContent> GetUserAndShopAndAction(int user_Id);
        
        Task<WebResponseContent> Login(LoginInfo loginInfo, bool verificationCode = true);
        Task<WebResponseContent> ReplaceToken();
        Task<WebResponseContent> ModifyPwd(string oldPwd, string newPwd);
        Task<WebResponseContent> GetCurrentUserInfo();
    }
}

