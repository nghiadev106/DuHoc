#pragma checksum "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afb067338235a7530f15abd7e15b6e0f4c788b24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_New_Detail), @"mvc.1.0.view", @"/Views/New/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\DA\DuHoc\DuHoc\Views\_ViewImports.cshtml"
using DuHoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DA\DuHoc\DuHoc\Views\_ViewImports.cshtml"
using DuHoc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb067338235a7530f15abd7e15b6e0f4c788b24", @"/Views/New/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3557f3a82d624f9477e00fbd975738ed8f3353f", @"/Views/_ViewImports.cshtml")]
    public class Views_New_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DuHoc.Models.News>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
  
    ViewData["Title"] = "Home Page";
    var related = (List<DuHoc.Models.News>)ViewBag.related;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""beacrum"">
    <div class=""container"">
        <ul class=""clearfix bdc_box""><li><a href=""/"">Trang chủ</a></li> <li class=""separator"">&rsaquo;</li> <li><a href=""/tin-tuc"">Tin tức</a> <li class=""separator"">&rsaquo;</li> </li><li class=""current"">");
#nullable restore
#line 8 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
                                                                                                                                                                                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li></ul>\r\n    </div>\r\n</div>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-9 content_col\">\r\n            <h1 class=\"single-title\"><span>");
#nullable restore
#line 14 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h1>\r\n            <div class=\"entry_content\">\r\n                ");
#nullable restore
#line 16 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
           Write(Html.Raw(Model.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"related_box\">\r\n                <h3 class=\"box-title\"><span>Bài viết liên quan</span></h3>\r\n                <div class=\"related_posts media_posts posts row\">\r\n");
#nullable restore
#line 21 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
                     if (related.Count() > 0)
                    {
                        foreach (var item in related)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-4\">\r\n                                <div class=\"wrap_cat\">\r\n                                    <div class=\"thumbs\">\r\n                                        <img width=\"560\" height=\"330\"");
            BeginWriteAttribute("src", " src=\"", 1262, "\"", 1279, 1);
#nullable restore
#line 28 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
WriteAttributeValue("", 1268, item.Image, 1268, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive wp-post-image\"");
            BeginWriteAttribute("alt", " alt=\"", 1317, "\"", 1323, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" />\r\n                                    </div>\r\n                                    <div class=\"inner\">\r\n                                        <h3 class=\"title\"><a");
            BeginWriteAttribute("href", " href=\"", 1505, "\"", 1548, 4);
            WriteAttributeValue("", 1512, "/tin-tuc/chi-tiet/", 1512, 18, true);
#nullable restore
#line 31 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
WriteAttributeValue("", 1530, item.Url, 1530, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1539, "/", 1539, 1, true);
#nullable restore
#line 31 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
WriteAttributeValue("", 1540, item.Id, 1540, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
                                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                        <div class=\"excerpt\">\r\n                                            ");
#nullable restore
#line 33 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
                                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 38 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
            </div>
            <div class=""comment"">
                <div class=""containers"">
                    <style>
                        div#respond h2 {
                            font-size: 14px;
                            font-weight: bold;
                        }

                        ol.commentlist li ul {
                            padding-left: 50px;
                        }

                            ol.commentlist li ul li ul {
                                padding-left: 100px;
                            }

                                ol.commentlist li ul li ul li ul {
                                    padding-left: 150px;
                                }

                        form#commentform {
                            position: relative;
                            padding-bottom: 25px;
                        }

                        * {
                            box-sizing: border-box;
                ");
            WriteLiteral(@"        }

                        h2#comments {
                            font-size: 16px;
                            margin: 0;
                            padding: 10px 0;
                            border-bottom: 1px solid #ccc;
                            margin-bottom: 15px;
                            position: relative;
                        }

                            h2#comments:after {
                                content: '';
                                position: absolute;
                                left: 0;
                                bottom: -2px;
                                border: 2px solid #fed700;
                                z-index: 1;
                                width: 15%;
                            }

                        .comment-meta.commentmetadata a {
                            color: #777;
                            font-size: 12px;
                            font-style: italic;
                        }

       ");
            WriteLiteral(@"                 .reply a {
                            text-decoration: underline;
                            color: #063f6f;
                            font-size: 12px;
                            font-style: italic;
                        }

                        cite.fn a, cite.fn {
                            font-weight: bold;
                            color: #000 !important;
                            font-style: initial;
                            display: inline-block;
                            width: 100%;
                            margin-top: 2px;
                            font-size: 11px;
                            height: 15px;
                            overflow: hidden;
                            text-align: center;
                        }

                        span.says {
                            display: none;
                        }

                        .comment {
                            /* background: #fafafa;*/
                 ");
            WriteLiteral(@"           padding: 5px 0;
                        }

                            .comment textarea {
                                height: 100px;
                            }

                            .comment .form-control {
                                margin-bottom: 10px;
                            }

                            .comment input#submit {
                                display: block;
                                background: #ceb423;
                                border: none;
                                padding: 5px 15px;
                                color: #fff;
                                outline: none;
                                border-radius: 4px;
                            }

                            .comment #url {
                                margin-right: 0 !important;
                            }

                            .comment ol {
                                padding: 0;
                                li");
            WriteLiteral(@"st-style: none;
                            }

                            .comment #author,
                            .comment #email,
                            .comment #url {
                                width: 40% !important;
                                text-align: left;
                            }

                        .cm_name, .cm_email {
                            display: inline-flex;
                            line-height: 34px;
                            width: 100%;
                        }

                            .cm_name label, .cm_email label {
                                margin-right: 15px;
                                margin-top: 2px;
                                width: 50px;
                            }

                        .comment ::-webkit-input-placeholder {
                            /* Chrome/Opera/Safari */
                            text-align: left;
                            font-style: italic;
                   ");
            WriteLiteral(@"     }

                        .comment ::-moz-placeholder {
                            /* Firefox 19+ */
                            text-align: left;
                            font-style: italic;
                        }

                        .comment:-ms-input-placeholder {
                            /* IE 10+ */
                            text-align: left;
                            font-style: italic;
                        }

                        .comment :-moz-placeholder {
                            /* Firefox 18- */
                            text-align: left;
                            font-style: italic;
                        }

                        .form-control,
                        .form-control:focus {
                            box-shadow: none;
                        }

                        .clearf {
                            clear: both;
                        }


                        /* list comment */
                     ");
            WriteLiteral(@"   .comment h2 {
                            font-weight: bold;
                            text-transform: uppercase;
                        }

                        .content-col > .comment {
                            border-top: 3px solid #777;
                        }

                        .comment-author.vcard {
                            width: 10%;
                            float: left;
                        }

                            .comment-author.vcard img {
                                border-radius: 100%;
                            }

                        .reply {
                            float: right;
                        }

                        .comment-author.vcard img {
                            margin-bottom: 5px;
                            display: block;
                            margin: auto;
                        }

                        .commentlist li p {
                            font-size: 14px;
               ");
            WriteLiteral(@"         }

                        .comment ol li {
                            display: inline-block;
                            width: 100%;
                        }

                        p.save_text input {
                            margin-right: 5px;
                        }

                        div#respond {
                            border-top: 1px solid #ccc;
                            padding: 15px 0;
                        }
                    </style>
                    <!-- If comments are open, but there are no comments. -->

                </div>
            </div>
        </div>
        <div class=""col-md-3 sidebar_col"">
            <div class=""sb_content"">
                <h3 class=""box-title"">Chương trình du học</h3>
                <div class=""col-inner"">
                    <div class=""list_cat"">
                        <div class=""thumb"">
                            <a href=""/du-hoc-nhat-ban/2"">
                                <img src=""https:");
            WriteLiteral(@"//vjvietnam.com.vn/wp-content/uploads/2021/10/du-hoc-nhat-ban-vj-2.png"" alt=""Du học nhật bản"" class=""img-responsive full-img"">
                            </a>
                        </div>
                        <h3 class=""sb_cat_title""> <a href=""/du-hoc-nhat-ban/2"">Du học nhật bản</a></h3>
                    </div>
                    <div class=""list_cat"">
                        <div class=""thumb"">
                            <a href=""/du-hoc-han-quoc/1002"">
                                <img src=""https://vjvietnam.com.vn/wp-content/uploads/2021/10/du-hoc-han-quoc-mien-phi-ky-tuc-xa.png"" alt=""Du học hàn quốc"" class=""img-responsive full-img"">
                            </a>
                        </div>
                        <h3 class=""sb_cat_title""> <a href=""/du-hoc-han-quoc/1002"">Du học hàn quốc</a></h3>
                    </div>
                </div>

                <div class=""sb_box newest"">
                    <h3 class=""box-title"">Tin tức</h3>
                    <div cl");
            WriteLiteral("ass=\"media_posts posts\">\r\n");
#nullable restore
#line 284 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
                         if (related.Count() > 0)
                        {
                            foreach (var item in related)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"post media\"");
            BeginWriteAttribute("href", " href=\"", 11358, "\"", 11401, 4);
            WriteAttributeValue("", 11365, "/tin-tuc/chi-tiet/", 11365, 18, true);
#nullable restore
#line 288 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
WriteAttributeValue("", 11383, item.Url, 11383, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 11392, "/", 11392, 1, true);
#nullable restore
#line 288 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
WriteAttributeValue("", 11393, item.Id, 11393, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"pull-left thumb\">\r\n                    <img width=\"150\" height=\"150\"");
            BeginWriteAttribute("src", " src=\"", 11501, "\"", 11518, 1);
#nullable restore
#line 290 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
WriteAttributeValue("", 11507, item.Image, 11507, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"media-object wp-post-image\"");
            BeginWriteAttribute("alt", " alt=\"", 11554, "\"", 11570, 1);
#nullable restore
#line 290 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
WriteAttributeValue("", 11560, item.Name, 11560, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" />\r\n                </div>\r\n                <div class=\"post_desc media-heading\">\r\n                    <h4 class=\"title\">");
#nullable restore
#line 293 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n            </a>");
#nullable restore
#line 295 "D:\DA\DuHoc\DuHoc\Views\New\Detail.cshtml"
                }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DuHoc.Models.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
