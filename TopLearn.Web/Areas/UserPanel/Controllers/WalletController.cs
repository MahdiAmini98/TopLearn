using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopLearn.Core.DTOs;
using TopLearn.Core.DTOs.MockPayment;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class WalletController : Controller
    {
        private IUserService _userService;
        private readonly IConfiguration _configuration;
        private readonly IMockPaymentService _mockPaymentService;

        public WalletController(IUserService userService, IConfiguration configuration, IMockPaymentService mockPaymentService)
        {
            _userService = userService;
            _configuration = configuration;
            _mockPaymentService = mockPaymentService;
        }

        [Route("UserPanel/Wallet")]
        public IActionResult Index()
        {
            ViewBag.ListWallet = _userService.GetWalletUser(User.Identity.Name);
            return View();
        }

        [Route("UserPanel/Wallet")]
        [HttpPost]
        public ActionResult Index(ChargeWalletViewModel charge)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ListWallet = _userService.GetWalletUser(User.Identity.Name);
                return View(charge);
            }

            int walletId = _userService.ChargeWallet(User.Identity.Name, charge.Amount, "شارژ حساب");

            #region Mock Payment
            var paymentRequest = new MockPaymentRequest
            {
                Amount = charge.Amount,
                CallbackUrl = Url.Action("PaymentResult", "MockPayment", new { area = "UserPanel" }, Request.Scheme),
                Description = "شارژ کیف پول",
                Email = "Info@topLearn.Com",
                Mobile = "09197070750",
                WalletId = walletId
            };

            var paymentResult = _mockPaymentService.CreatePaymentRequest(paymentRequest);

            if (paymentResult.Success)
            {
                return RedirectToAction("Pay", "MockPayment", new { area = "UserPanel", authority = paymentResult.Authority });
            }
            #endregion

            ModelState.AddModelError("", "خطا در ایجاد درگاه پرداخت");
            ViewBag.ListWallet = _userService.GetWalletUser(User.Identity.Name);
            return View(charge);
        }
    }
}