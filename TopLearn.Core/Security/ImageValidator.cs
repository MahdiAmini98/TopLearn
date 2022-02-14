using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace TopLearn.Core.Security
{
    //این کلاس در ذخیره کردن عکس های دوره ها به ما کمک میکند. به این صورت که اگر فایل انتخاب شده از نوع عکس نباشد اجازه آپلود داده نمیشود

    public static class ImageValidator
    {
        public static bool IsImage(this IFormFile file)
        {
            try
            {
                var img = System.Drawing.Image.FromStream(file.OpenReadStream());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
