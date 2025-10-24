using Microsoft.AspNetCore.Mvc;
using TopLearn.Core.DTOs.MockPayment;
using TopLearn.Core.Services.Interfaces;
namespace TopLearn.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class MockPaymentController : Controller
    {
        private readonly IMockPaymentService _paymentService;
        private readonly IUserService _userService;

        public MockPaymentController(IMockPaymentService paymentService, IUserService userService)
        {
            _paymentService = paymentService;
            _userService = userService;
        }

        [Route("UserPanel/MockPayment/Pay/{authority}")]
        public IActionResult Pay(string authority)
        {
            var payment = _paymentService.GetPaymentByAuthority(authority);
            if (payment == null)
            {
                return NotFound("تراکنش یافت نشد");
            }

            var model = new MockPaymentViewModel
            {
                Amount = payment.Amount,
                Description = payment.Description,
                Authority = authority,
                CallbackUrl = payment.CallbackUrl,
                Email = payment.Email,
                Mobile = payment.Mobile
            };

            return View(model);
        }

        [HttpPost]
        [Route("UserPanel/MockPayment/ConfirmPayment")]
        public IActionResult ConfirmPayment(string authority, bool isSuccess = true)
        {
            var payment = _paymentService.GetPaymentByAuthority(authority);
            if (payment == null)
            {
                return NotFound("تراکنش یافت نشد");
            }

            string status = isSuccess ? "success" : "failed";

            if (isSuccess)
            {
                _paymentService.UpdatePaymentStatus(authority, true);

                var wallet = _userService.GetWalletByWalletId(payment.WalletId);
                if (wallet != null)
                {
                    wallet.IsPay = true;
                    _userService.UpdateWallet(wallet);
                }
            }
            else
            {
                _paymentService.UpdatePaymentStatus(authority, false);
            }

            return RedirectToAction("PaymentResult", new
            {
                walletId = payment.WalletId,
                authority = authority,
                status = status
            });
        }

        [Route("UserPanel/MockPayment/PaymentResult")]
        public IActionResult PaymentResult(int walletId, string authority, string status)
        {
            ViewBag.WalletId = walletId;
            ViewBag.Authority = authority;
            ViewBag.Status = status;

            if (status == "success")
            {
                ViewBag.Message = "پرداخت با موفقیت انجام شد";
                ViewBag.IsSuccess = true;
            }
            else
            {
                ViewBag.Message = "پرداخت ناموفق بود";
                ViewBag.IsSuccess = false;
            }

            return View();
        }
    }
}
