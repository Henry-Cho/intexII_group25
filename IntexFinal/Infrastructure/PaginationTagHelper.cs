﻿using System;
using IntexFinal.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace IntexFinal.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-list")]
    public class PaginationTagHelper : TagHelper
    {
        // create a url instance
        private IUrlHelperFactory uhf;

        // constructor
        public PaginationTagHelper(IUrlHelperFactory temp)
        {
            uhf = temp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext vc { get; set; }

        // Different than the View Context
        // This is for adding class to the target element
        public PageInfo PageList { get; set; }
        public string PageAction { get; set; }
        // CSS enabling
        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }

        public override void Process(TagHelperContext thc, TagHelperOutput tho)
        {
            IUrlHelper uh = uhf.GetUrlHelper(vc);

            // add element in the target element (div)
            TagBuilder final = new TagBuilder("div");
            string anchorInnerHtml = "";

            for (int i = PageList.CurrentPage - 3; i <= PageList.TotalPages; i++)
            {
                if (i <= 0)
                {
                    continue;
                }
                if (i > PageList.CurrentPage + 3 || (i == PageList.CurrentPage - 3))
                {
                    TagBuilder tag = new TagBuilder("a");
                    anchorInnerHtml = "...";

                    if (anchorInnerHtml == "..")
                        tag.Attributes["href"] = "#";
                    else if (i == 1)
                        tag.Attributes["href"] = "/page1";
                    else
                        tag.Attributes["href"] = "/page" + i;

                    if (PageClassesEnabled)
                    {
                        tag.AddCssClass(PageClass);
                        tag.AddCssClass(i == PageList.CurrentPage ? PageClassSelected : "");
                    }

                    tag.InnerHtml.Append(anchorInnerHtml);

                    if (anchorInnerHtml != "")
                    {
                        final.InnerHtml.AppendHtml(tag);
                    }
                    if (i > PageList.CurrentPage + 3)
                    {
                        break;
                    }

                }
                else
                {
                    TagBuilder tag = new TagBuilder("a");

                    anchorInnerHtml = AnchorInnerHtml(i, PageList);

                    if (anchorInnerHtml == "..")
                        tag.Attributes["href"] = "#";
                    else if (i == 1)
                        tag.Attributes["href"] = "/page1";
                    else
                        tag.Attributes["href"] = "/page" + i;

                    if (PageClassesEnabled)
                    {
                        tag.AddCssClass(PageClass);
                        tag.AddCssClass(i == PageList.CurrentPage ? PageClassSelected : "");
                    }

                    tag.InnerHtml.Append(anchorInnerHtml);

                    if (anchorInnerHtml != "")
                        final.InnerHtml.AppendHtml(tag);
                }

                // append the final's innerhtml in the taghelperoutput
                tho.Content.AppendHtml(final.InnerHtml);
            }

        }

        private string AnchorInnerHtml(int i, PageInfo pagingInfo)
        {
            string anchorInnerHtml = "";
            if (pagingInfo.TotalPages <= 10)
                anchorInnerHtml = i.ToString();
            else
            {
                if (pagingInfo.CurrentPage <= 5)
                {
                    if ((i <= 8) || (i == pagingInfo.TotalPages))
                        anchorInnerHtml = i.ToString();
                    else if (i == pagingInfo.TotalPages - 1)
                        anchorInnerHtml = "..";
                }
                else if ((pagingInfo.CurrentPage > 5) && (pagingInfo.TotalPages - pagingInfo.CurrentPage >= 5))
                {
                    if ((i == 1) || (i == pagingInfo.TotalPages) || ((pagingInfo.CurrentPage - i >= -3) && (pagingInfo.CurrentPage - i <= 3)))
                        anchorInnerHtml = i.ToString();
                    else if ((i == pagingInfo.CurrentPage - 4) || (i == pagingInfo.CurrentPage + 4))
                        anchorInnerHtml = "..";
                }
                else if (pagingInfo.TotalPages - pagingInfo.CurrentPage < 5)
                {
                    if ((i == 1) || (pagingInfo.TotalPages - i <= 7))
                        anchorInnerHtml = i.ToString();
                    else if (pagingInfo.TotalPages - i == 8)
                        anchorInnerHtml = "..";
                }
            }
            return anchorInnerHtml;
        }

    }
}