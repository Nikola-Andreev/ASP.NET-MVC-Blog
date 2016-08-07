using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;


namespace MVCBlog.Clases
{
    public class Utils
    {
        public static string CutText(string text, int maxLenght = 200) 
        {
            if (text.Length <= maxLenght || text == null)
            {
                return text;
            }
            var shortText = text.Substring(0, maxLenght) + " ...";
            return shortText;
        }
    }
}