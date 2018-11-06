using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EM.Calc.Web.Exstentions
{
    public static class Helpers
    {
        public static MvcHtmlString SuperButton(this HtmlHelper htmlHelper)
        {
            return new MvcHtmlString("<input =\"button\" value=\"Super\" />");
        }
    }
}