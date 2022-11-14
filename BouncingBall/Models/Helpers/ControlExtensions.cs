using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BouncingBall.Models.Controls;

namespace BouncingBall.Models.Helpers
{
    public static class ControlExtensions
    {
        public static HtmlString CtrlBouncingBall(this HtmlHelper html, string id, int height, int width)
        {
            var ctrl = new CtrlBouncingBall
            {
                Id = id,
                Width = width,
                Height = height
            };

            return new HtmlString(ctrl.GetHtml());
        }
    }
}