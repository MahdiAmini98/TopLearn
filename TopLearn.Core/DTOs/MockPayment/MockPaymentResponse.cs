using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopLearn.Core.DTOs.MockPayment
{
    public class MockPaymentResponse
    {
        public bool Success { get; set; }
        public string Authority { get; set; }
        public string PaymentUrl { get; set; }
        public string Message { get; set; }
    }

}
