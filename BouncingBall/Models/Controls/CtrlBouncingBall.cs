using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BouncingBall.Models.Controls
{
    public class CtrlBouncingBall : CtrlBaseModel
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public CtrlBouncingBall()
        {
        }
    }
}