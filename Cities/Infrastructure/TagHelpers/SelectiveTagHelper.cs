﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities.Infrastructure.TagHelpers
{
    [HtmlTargetElement(Attributes = "show-for-action")]
    public class SelectiveTagHelper : TagHelper
    {
        public string ShowForAction { get; set; }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!ViewContext.RouteData.Values["action"].ToString().Equals(ShowForAction, StringComparison.OrdinalIgnoreCase))
            {
                output.SuppressOutput();
            }
        }
    }
}
