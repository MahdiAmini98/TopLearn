using System;
using System.Collections.Generic;
using System.Text;

namespace TopLearn.Core.Generator
{
    //ساختن کد فعال سازی ایمیل -یک کد فعال سازی برای ایمیل می سازد (Active-code)
    public class NameGenerator
    {
        public static string GenerateUniqCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
