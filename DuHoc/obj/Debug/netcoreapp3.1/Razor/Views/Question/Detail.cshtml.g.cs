#pragma checksum "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61630e9f345c79f9b6e6a2e75d85cc359048cdfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_Detail), @"mvc.1.0.view", @"/Views/Question/Detail.cshtml")]
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
#line 1 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\_ViewImports.cshtml"
using DuHoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\_ViewImports.cshtml"
using DuHoc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61630e9f345c79f9b6e6a2e75d85cc359048cdfc", @"/Views/Question/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3557f3a82d624f9477e00fbd975738ed8f3353f", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DuHoc.Models.Question>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
   ViewData["Title"] = "Home Page";
                var related = (List<DuHoc.Models.Question>)ViewBag.related;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"beacrum\">\n    <div class=\"container\">\n        <ul class=\"clearfix bdc_box\"><li><a href=\"https://vjvietnam.com.vn\">Trang chủ</a></li> <li class=\"separator\">&rsaquo;</li> <li class=\"current\">");
#nullable restore
#line 7 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
                                                                                                                                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li></ul>\n    </div>\n</div>\n<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-md-9 content_col\">\n            <h1 class=\"single-title\"><span>");
#nullable restore
#line 13 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h1>
            <div class=""entry_content"">
                
            </div>
            <div class=""related_box"">
                <h3 class=""box-title""><span>Câu hỏi liên quan</span></h3>
                <div class=""related_posts media_posts posts row"">
");
#nullable restore
#line 20 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
                     if (related.Count() > 0)
                    {
                        foreach (var item in related)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\n                    <div class=\"wrap_cat\">\n                        <div class=\"thumbs\">\n                            <img width=\"560\" height=\"330\"");
            BeginWriteAttribute("src", " src=\"", 1130, "\"", 1147, 1);
#nullable restore
#line 27 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
WriteAttributeValue("", 1136, item.Image, 1136, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive wp-post-image\"");
            BeginWriteAttribute("alt", " alt=\"", 1185, "\"", 1191, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" />\n                        </div>\n                        <div class=\"inner\">\n                            <h3 class=\"title\"><a");
            BeginWriteAttribute("href", " href=\"", 1334, "\"", 1377, 4);
            WriteAttributeValue("", 1341, "/cau-hoi/chi-tiet/", 1341, 18, true);
#nullable restore
#line 30 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
WriteAttributeValue("", 1359, item.Url, 1359, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1368, "/", 1368, 1, true);
#nullable restore
#line 30 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
WriteAttributeValue("", 1369, item.Id, 1369, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
                                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\n                            <div class=\"excerpt\">\n                                ");
#nullable restore
#line 32 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>");
#nullable restore
#line 36 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
                      }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
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
                        }

                      ");
            WriteLiteral(@"  h2#comments {
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

                        .reply a {
                            text");
            WriteLiteral(@"-decoration: underline;
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
                            padding: 5px 0;
                        }

                            .com");
            WriteLiteral(@"ment textarea {
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
                                list-style: none;
                            }

                            .comment #author,
                    ");
            WriteLiteral(@"        .comment #email,
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
                        }

                        .comment ::-moz-placeholder {
                            /* Firefox 19+ */
                            tex");
            WriteLiteral(@"t-align: left;
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
                        .comment h2 {
                            font-weight: bold;
                            text-transform: uppercase;
                        }

                        ");
            WriteLiteral(@".content-col > .comment {
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
                        }

                        .comment ol li {
                            display: inline-block;
                            width: 100%;
                        }

                        p.sa");
            WriteLiteral(@"ve_text input {
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
                                <img src=""https://vjvietnam.com.vn/wp-content/uploads/2021/10/du-hoc-nhat-ban-vj-2.png"" alt=""Du học nhật bản"" class=""img-responsive full-img"">
                            </a>
                        </div>
                        <h3 class=""sb");
            WriteLiteral(@"_cat_title""> <a href=""/du-hoc-nhat-ban/2"">Du học nhật bản</a></h3>
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
                    <div class=""media_posts posts"">
");
#nullable restore
#line 280 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
                         if (related.Count() > 0)
                        {
                            foreach (var item in related)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"post media\"");
            BeginWriteAttribute("href", " href=\"", 10839, "\"", 10882, 4);
            WriteAttributeValue("", 10846, "/cau-hoi/chi-tiet/", 10846, 18, true);
#nullable restore
#line 284 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
WriteAttributeValue("", 10864, item.Url, 10864, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10873, "/", 10873, 1, true);
#nullable restore
#line 284 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
WriteAttributeValue("", 10874, item.Id, 10874, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"pull-left thumb\">\n                    <img width=\"150\" height=\"150\"");
            BeginWriteAttribute("src", " src=\"", 10980, "\"", 10997, 1);
#nullable restore
#line 286 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
WriteAttributeValue("", 10986, item.Image, 10986, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"media-object wp-post-image\"");
            BeginWriteAttribute("alt", " alt=\"", 11033, "\"", 11049, 1);
#nullable restore
#line 286 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
WriteAttributeValue("", 11039, item.Name, 11039, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" />\n                </div>\n                <div class=\"post_desc media-heading\">\n                    <h4 class=\"title\">");
#nullable restore
#line 289 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                </div>\n            </a>");
#nullable restore
#line 291 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\Question\Detail.cshtml"
                }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DuHoc.Models.Question> Html { get; private set; }
    }
}
#pragma warning restore 1591
