#pragma checksum "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de1c97110181f50b5dcf6d2c9eb37553286e7877"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_New_Category), @"mvc.1.0.view", @"/Views/New/Category.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de1c97110181f50b5dcf6d2c9eb37553286e7877", @"/Views/New/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3557f3a82d624f9477e00fbd975738ed8f3353f", @"/Views/_ViewImports.cshtml")]
    public class Views_New_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DuHoc.ViewModels.Common.PaginationSet<DuHoc.Models.News>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
  
    ViewData["Title"] = "Home Page";
    var category = (DuHoc.Models.CommonCategory)ViewBag.category;
    var questions = (List<DuHoc.Models.Question>)ViewBag.questions;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""main_body"">
    <div class=""home_slider"">
        <div id=""home_slider"">
            <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""5000"">
                <ol class=""carousel-indicators"">
                    <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                    <li data-target=""#myCarousel"" data-slide-to=""2""></li>
                    <li data-target=""#myCarousel"" data-slide-to=""3""></li>
                </ol>
                <div class=""carousel-inner"">
                    <div class=""item active"">
                        <li><img width=""1520"" height=""450"" src=""https://vjvietnam.com.vn/wp-content/uploads/2019/08/sl1.jpg"" class=""img-responsive wp-post-image""");
            BeginWriteAttribute("alt", " alt=\"", 1077, "\"", 1083, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" /></li>
                    </div>
                    <div class=""item no-active"">
                        <li><img width=""1520"" height=""450"" src=""https://vjvietnam.com.vn/wp-content/uploads/2019/08/sl2.jpg"" class=""img-responsive wp-post-image""");
            BeginWriteAttribute("alt", " alt=\"", 1348, "\"", 1354, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" /></li>
                    </div>
                    <div class=""item no-active"">
                        <li><img width=""1520"" height=""450"" src=""https://vjvietnam.com.vn/wp-content/uploads/2021/10/sl3.jpg"" class=""img-responsive wp-post-image""");
            BeginWriteAttribute("alt", " alt=\"", 1619, "\"", 1625, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" /></li>
                    </div>
                    <div class=""item no-active"">
                        <li><img width=""2560"" height=""758"" src=""https://vjvietnam.com.vn/wp-content/uploads/2021/10/z2882041514755_88416e5414a6d1e2faf5834ae522711f-scaled.jpg"" class=""img-responsive wp-post-image""");
            BeginWriteAttribute("alt", " alt=\"", 1941, "\"", 1947, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" srcset=""https://vjvietnam.com.vn/wp-content/uploads/2021/10/z2882041514755_88416e5414a6d1e2faf5834ae522711f-scaled.jpg 2560w, https://vjvietnam.com.vn/wp-content/uploads/2021/10/z2882041514755_88416e5414a6d1e2faf5834ae522711f-300x89.jpg 300w, https://vjvietnam.com.vn/wp-content/uploads/2021/10/z2882041514755_88416e5414a6d1e2faf5834ae522711f-1024x303.jpg 1024w, https://vjvietnam.com.vn/wp-content/uploads/2021/10/z2882041514755_88416e5414a6d1e2faf5834ae522711f-768x227.jpg 768w, https://vjvietnam.com.vn/wp-content/uploads/2021/10/z2882041514755_88416e5414a6d1e2faf5834ae522711f-1536x455.jpg 1536w, https://vjvietnam.com.vn/wp-content/uploads/2021/10/z2882041514755_88416e5414a6d1e2faf5834ae522711f-2048x606.jpg 2048w"" sizes=""(max-width: 2560px) 100vw, 2560px"" /></li>
                    </div>
                </div>
            </div>
            <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">
                <span class=""glyphicon glyphicon-chevron-left""></span>
        ");
            WriteLiteral(@"        <span class=""sr-only"">Previous</span>
            </a>
            <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">
                <span class=""glyphicon glyphicon-chevron-right""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div><div class=""beacrum"">
        <div class=""container"">
            <ul class=""clearfix bdc_box""><li><a href=""/"">Trang chủ</a></li> <li class=""separator"">&rsaquo;</li> <li class=""current"">");
#nullable restore
#line 45 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                                                                                                                               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li></ul>\r\n        </div>\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-9 content_col\">\r\n                <h2 class=\"page-title\">\r\n                    ");
#nullable restore
#line 52 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n                <div class=\"row posts tax_li\">\r\n");
#nullable restore
#line 55 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                     if (Model.Count > 0)
                    {
                        foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-md-6"">
                                <div class=""post_list"">
                                    <div class=""row"">
                                        <div class=""col-md-6"">
                                            <div class=""thumbs thumb"">
                                                <a");
            BeginWriteAttribute("href", " href=\"", 4286, "\"", 4329, 4);
            WriteAttributeValue("", 4293, "/tin-tuc/chi-tiet/", 4293, 18, true);
#nullable restore
#line 64 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 4311, item.Url, 4311, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4320, "/", 4320, 1, true);
#nullable restore
#line 64 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 4321, item.Id, 4321, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <img width=\"560\" height=\"330\"");
            BeginWriteAttribute("src", " src=\"", 4414, "\"", 4431, 1);
#nullable restore
#line 65 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 4420, item.Image, 4420, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive thumbmd wp-post-image\"");
            BeginWriteAttribute("alt", " alt=\"", 4477, "\"", 4493, 1);
#nullable restore
#line 65 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 4483, item.Name, 4483, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                </a>
                                            </div>
                                        </div>
                                        <div class=""col-md-6 post_desc"">
                                            <div class=""inner_post"">
                                                <h3 class=""title""><a");
            BeginWriteAttribute("href", " href=\"", 4865, "\"", 4898, 2);
            WriteAttributeValue("", 4872, "/tin-tuc/chi-tiet/", 4872, 18, true);
#nullable restore
#line 71 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 4890, item.Id, 4890, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                                                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 77 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"paginate\">\r\n");
#nullable restore
#line 83 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                     if (Model.TotalPages > 1)
                    {
                        // Create numeric links
                        var startPageIndex = Math.Max(1, Model.Page - Model.MaxPage / 2);
                        var endPageIndex = Math.Min(Model.TotalPages, Model.Page + Model.MaxPage / 2);


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <nav>\r\n                            <ul class=\"pagination\">\r\n");
#nullable restore
#line 91 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                                 if (Model.Page > 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class=""page-item"">
                                        <a class=""page-link"" href=""?page=1"" aria-label=""First"">
                                            <i class=""fa fa-angle-double-left""></i>
                                        </a>
                                    </li>
                                    <li class=""page-item"">
                                        <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 6200, "\"", 6228, 2);
            WriteAttributeValue("", 6207, "?page=", 6207, 6, true);
#nullable restore
#line 99 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 6213, Model.Page-1, 6213, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                            <i class=\"fa fa-angle-double-left\"></i>\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 103 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                                 for (int i = startPageIndex; i <= endPageIndex; i++)
                                {
                                    if (Model.Page == i)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"active page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6771, "\"", 6786, 2);
            WriteAttributeValue("", 6778, "?page=", 6778, 6, true);
#nullable restore
#line 108 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 6784, i, 6784, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 6787, "\"", 6803, 2);
            WriteAttributeValue("", 6795, "Trang", 6795, 5, true);
#nullable restore
#line 108 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue(" ", 6800, i, 6801, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 108 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 109 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 7020, "\"", 7035, 2);
            WriteAttributeValue("", 7027, "?page=", 7027, 6, true);
#nullable restore
#line 112 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 7033, i, 7033, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 7036, "\"", 7052, 2);
            WriteAttributeValue("", 7044, "Trang", 7044, 5, true);
#nullable restore
#line 112 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue(" ", 7049, i, 7050, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 112 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                                                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 113 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                                 if (Model.Page < Model.TotalPages)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 7365, "\"", 7393, 2);
            WriteAttributeValue("", 7372, "?page=", 7372, 6, true);
#nullable restore
#line 118 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 7378, Model.Page+1, 7378, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Next"">
                                            <i class=""fa fa-angle-double-right""></i>
                                        </a>
                                    </li>
                                    <li class=""page-item"">
                                        <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 7710, "\"", 7740, 2);
            WriteAttributeValue("", 7717, "?page=", 7717, 6, true);
#nullable restore
#line 123 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 7723, Model.TotalPages, 7723, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Last\">\r\n                                            <i class=\"fa fa-angle-double-right\"></i>\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 127 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </nav>\r\n");
#nullable restore
#line 130 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
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
ol.commentlist li ul li ul{
    padding-left: 100px;
}
ol.commentlist li ul li ul li ul{
    padding-left: 150px;
}
form#commentform {
    position: relative;
    padding-bottom: 25px;
}

* {
    box-sizing: border-box;
}
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

.reply a {
    text-decoration: underline;
    color: #063f6f;
    font-size: 12px;");
            WriteLiteral(@"
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
    list-style: none;
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
.cm_name label, .cm_ema");
            WriteLiteral(@"il label {
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
.comment h2 {
    font-weight: bold;
    text-transform: uppercase;
}

.content-col>.comment {
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
    ma");
            WriteLiteral("rgin: auto;\r\n}\r\n.commentlist li p {\r\n    font-size: 14px;\r\n}\r\n\r\n.comment ol li {\r\n    display: inline-block;\r\n    width: 100%;\r\n}\r\np.save_text input {\r\n    margin-right: 5px;\r\n}\r\ndiv#respond {\r\n    border-top: 1px solid #ccc;\r\n    padding: 15px 0;\r\n}\r\n");
            WriteLiteral(@"@media screen and (max-width: 768px){
    .comment-author.vcard {
    width: 18%;
    float: left;
    }
    .comment #author, .comment #email, .comment #url {
        width: 100%!important;
        text-align: left;
    }
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
                             ");
            WriteLiteral(@"   </a>
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
                        <h3 class=""box-title"">Câu hỏi</h3>
                        <div class=""media_posts posts"">
");
#nullable restore
#line 370 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                             if (questions.Count() > 0)
                            {
                                foreach (var item in questions)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"post media\"");
            BeginWriteAttribute("href", " href=\"", 13613, "\"", 13656, 4);
            WriteAttributeValue("", 13620, "/cau-hoi/chi-tiet/", 13620, 18, true);
#nullable restore
#line 374 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 13638, item.Url, 13638, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 13647, "/", 13647, 1, true);
#nullable restore
#line 374 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 13648, item.Id, 13648, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"pull-left thumb\">\r\n                                            <img width=\"150\" height=\"150\"");
            BeginWriteAttribute("src", " src=\"", 13804, "\"", 13821, 1);
#nullable restore
#line 376 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 13810, item.Image, 13810, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"media-object wp-post-image\"");
            BeginWriteAttribute("alt", " alt=\"", 13857, "\"", 13873, 1);
#nullable restore
#line 376 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
WriteAttributeValue("", 13863, item.Name, 13863, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" />\r\n                                        </div>\r\n                                        <div class=\"post_desc media-heading\">\r\n                                            <h4 class=\"title\">");
#nullable restore
#line 379 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        </div>\r\n                                    </a>\r\n");
#nullable restore
#line 382 "D:\DA\DuHoc\DuHoc\Views\New\Category.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--end main body-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DuHoc.ViewModels.Common.PaginationSet<DuHoc.Models.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
