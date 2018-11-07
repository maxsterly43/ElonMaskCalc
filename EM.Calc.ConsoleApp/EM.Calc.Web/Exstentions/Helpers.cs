using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EM.Calc.Web.Exstentions
{
    public static class Helpers
    {
        public static MvcHtmlString SuperButton(this HtmlHelper htmlHelper, string text, string onclick)
        {  
            return new MvcHtmlString($"<input type = \"button\" value = \"{text}\" onclick = \"{onclick}\" class=\"btn btn - default\" />");
        }

    }
}