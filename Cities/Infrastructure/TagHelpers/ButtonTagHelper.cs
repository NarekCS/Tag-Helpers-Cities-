﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities.Infrastructure.TagHelpers
{
    [HtmlTargetElement("button", Attributes = "bs-button-color", ParentTag = "form")]
    [HtmlTargetElement("a" , Attributes = "bs-button-color", ParentTag = "form")]
    public class ButtonTagHelper : TagHelper
    {
        public string BsButtonColor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"btn btn-{BsButtonColor}");
        }
    }
}
