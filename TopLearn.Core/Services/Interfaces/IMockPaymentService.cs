using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopLearn.Core.DTOs.MockPayment;

namespace TopLearn.Core.Services.Interfaces
{
    public interface IMockPaymentService
    {
        MockPaymentResponse CreatePaymentRequest(MockPaymentRequest request);
        MockPaymentRequest GetPaymentByAuthority(string authority);
        bool VerifyPayment(string authority);
        void UpdatePaymentStatus(string authority, bool isSuccess);
    }
}
