using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Hetao.Framework.Web
{
    public class TextAttribute : UIHintAttribute
    {
        public TextAttribute()
            : base("Text")
        {
        }
    }
}
