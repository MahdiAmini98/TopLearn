using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopLearn.Core.DTOs.MockPayment
{
    public class MockPaymentViewModel
    {
        public int Amount { get; set; }
        public string Description { get; set; }
        public string Authority { get; set; }
        public string CallbackUrl { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
