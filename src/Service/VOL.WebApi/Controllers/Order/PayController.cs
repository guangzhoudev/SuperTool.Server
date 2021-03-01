//using Microsoft.AspNetCore.Mvc;
//using System.Threading.Tasks;
//using VOL.Core.Controllers.Basic;
//using Essensoft.AspNetCore.Payment.Alipay.Domain;
//using VOL.Order.IServices;
//using WebApplicationSample.Models;
//using Essensoft.AspNetCore.Payment.WeChatPay.V2.Request;
//using Essensoft.AspNetCore.Payment.WeChatPay.V2;
//using Essensoft.AspNetCore.Payment.WeChatPay;
//using Microsoft.Extensions.Options;

namespace VOL.Order.Controllers
{
    //[Route("api/Pay")]
    public partial class PayController //: ApiBaseController<IAdService>
    {
        //private readonly IWeChatPayClient _client;
        //private readonly IOptions<WeChatPayOptions> _optionsAccessor;

        //public PayController(IWeChatPayClient client, IOptions<WeChatPayOptions> optionsAccessor)
        //{
        //    _client = client;
        //    _optionsAccessor = optionsAccessor;
        //}
        ///// <summary>
        ///// 扫码支付-微信
        ///// </summary>
        ///// <param name="viewModel"></param>
        //[HttpPost]
        //public async Task<IActionResult> QrCodePay(WeChatPayQrCodePayViewModel viewModel)
        //{
        //    var request = new WeChatPayUnifiedOrderRequest
        //    {
        //        Body = viewModel.Body,
        //        OutTradeNo = viewModel.OutTradeNo,
        //        TotalFee = viewModel.TotalFee,
        //        SpBillCreateIp = viewModel.SpBillCreateIp,
        //        NotifyUrl = viewModel.NotifyUrl,
        //        TradeType = viewModel.TradeType,
        //        ProfitSharing = viewModel.ProfitSharing
        //    };

        //    var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

        //    // response.CodeUrl 给前端生成二维码
        //    ViewData["qrcode"] = response.CodeUrl;
        //    ViewData["response"] = response.Body;
        //    return View();
        //}



    }
}

