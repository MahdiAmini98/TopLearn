using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopLearn.Core.DTOs.MockPayment;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Core.Services
{
    public class MockPaymentService : IMockPaymentService
    {
        private static readonly Dictionary<string, MockPaymentRequest> _payments = new();
        private static readonly Dictionary<string, bool> _paymentStatus = new();

        public MockPaymentResponse CreatePaymentRequest(MockPaymentRequest request)
        {
            var authority = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 20);

            _payments[authority] = request;
            _paymentStatus[authority] = false;

            return new MockPaymentResponse
            {
                Success = true,
                Authority = authority,
                PaymentUrl = $"/UserPanel/MockPayment/Pay/{authority}",
                Message = "پرداخت تستی با موفقیت ایجاد شد"
            };
        }

        public MockPaymentRequest GetPaymentByAuthority(string authority)
        {
            return _payments.ContainsKey(authority) ? _payments[authority] : null;
        }

        public bool VerifyPayment(string authority)
        {
            return _paymentStatus.ContainsKey(authority) && _paymentStatus[authority];
        }

        public void UpdatePaymentStatus(string authority, bool isSuccess)
        {
            if (_paymentStatus.ContainsKey(authority))
            {
                _paymentStatus[authority] = isSuccess;
            }
        }
    }
}
