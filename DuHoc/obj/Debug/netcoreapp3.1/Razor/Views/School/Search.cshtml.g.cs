#pragma checksum "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b926b52c0aad46ad9256c7c420122fbcb8b37d4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_Search), @"mvc.1.0.view", @"/Views/School/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b926b52c0aad46ad9256c7c420122fbcb8b37d4b", @"/Views/School/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3557f3a82d624f9477e00fbd975738ed8f3353f", @"/Views/_ViewImports.cshtml")]
    public class Views_School_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DuHoc.ViewModels.Common.PaginationSet<DuHoc.Models.School>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""main_body"">
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
            BeginWriteAttribute("alt", " alt=\"", 941, "\"", 947, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" /></li>
                    </div>
                    <div class=""item no-active"">
                        <li><img width=""1520"" height=""450"" src=""https://vjvietnam.com.vn/wp-content/uploads/2019/08/sl2.jpg"" class=""img-responsive wp-post-image""");
            BeginWriteAttribute("alt", " alt=\"", 1212, "\"", 1218, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" /></li>
                    </div>
                    <div class=""item no-active"">
                        <li><img width=""1520"" height=""450"" src=""https://vjvietnam.com.vn/wp-content/uploads/2021/10/sl3.jpg"" class=""img-responsive wp-post-image""");
            BeginWriteAttribute("alt", " alt=\"", 1483, "\"", 1489, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" /></li>
                    </div>
                    <div class=""item no-active"">
                        <li><img width=""2560"" height=""758"" src=""https://vjvietnam.com.vn/wp-content/uploads/2021/10/z2882041514755_88416e5414a6d1e2faf5834ae522711f-scaled.jpg"" class=""img-responsive wp-post-image""");
            BeginWriteAttribute("alt", " alt=\"", 1805, "\"", 1811, 0);
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
    </div><div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 content_col"">
                <h1 class=""single-title text-center cus-title""><span>");
#nullable restore
#line 43 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                                                Write(ViewBag.keyword);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h1>\r\n                <div class=\"box_all\">\r\n                    <div class=\"posts cat_li\">\r\n                        <div class=\"row\">\r\n");
#nullable restore
#line 47 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                             if (Model.Count > 0)
                            {
                                foreach (var item in Model.Items)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-md-3\">\r\n                                        <div class=\"wrap_cat col_pcat\">\r\n                                            <div class=\"thumb\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 3916, "\"", 3953, 4);
            WriteAttributeValue("", 3923, "/truong-hoc/", 3923, 12, true);
#nullable restore
#line 54 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 3935, item.Url, 3935, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3944, "/", 3944, 1, true);
#nullable restore
#line 54 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 3945, item.Id, 3945, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <img width=\"560\" height=\"330\"");
            BeginWriteAttribute("src", " src=\"", 4038, "\"", 4055, 1);
#nullable restore
#line 55 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 4044, item.Image, 4044, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive wp-post-image\"");
            BeginWriteAttribute("alt", " alt=\"", 4093, "\"", 4099, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" />\r\n                                                </a>\r\n                                                <span class=\"eview\"><i class=\"fa fa-eye\"></i> ");
#nullable restore
#line 57 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                                                                         Write(item.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                <p class=\"spn_lt\"><i class=\"fa fa-map-marker\"></i> ");
#nullable restore
#line 58 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                                                                              Write(item.AddressDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                            <div class=\"inner\">\r\n                                                <h3 class=\"title\"><a");
            BeginWriteAttribute("href", " href=\"", 4601, "\"", 4638, 4);
            WriteAttributeValue("", 4608, "/truong-hoc/", 4608, 12, true);
#nullable restore
#line 61 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 4620, item.Url, 4620, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4629, "/", 4629, 1, true);
#nullable restore
#line 61 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 4630, item.Id, 4630, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                                <div class=\"excerpt\">\r\n                                                    ");
#nullable restore
#line 63 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                               Write(item.SortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 68 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"

                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n                <div>\r\n");
#nullable restore
#line 75 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
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
#line 83 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                 if (Model.Page > 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5792, "\"", 5829, 3);
            WriteAttributeValue("", 5799, "?keyword=", 5799, 9, true);
#nullable restore
#line 86 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 5808, Model.Keyword, 5808, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5822, "&page=1", 5822, 7, true);
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""First"">
                                            <i class=""fa fa-angle-double-left""></i>
                                        </a>
                                    </li>
                                    <li class=""page-item"">
                                        <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 6146, "\"", 6197, 4);
            WriteAttributeValue("", 6153, "?keyword=", 6153, 9, true);
#nullable restore
#line 91 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 6162, Model.Keyword, 6162, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6176, "&page=", 6176, 6, true);
#nullable restore
#line 91 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 6182, Model.Page-1, 6182, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                            <i class=\"fa fa-angle-double-left\"></i>\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 95 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                 for (int i = startPageIndex; i <= endPageIndex; i++)
                                {
                                    if (Model.Page == i)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"active page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6740, "\"", 6778, 4);
            WriteAttributeValue("", 6747, "?keyword=", 6747, 9, true);
#nullable restore
#line 100 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 6756, Model.Keyword, 6756, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6770, "&page=", 6770, 6, true);
#nullable restore
#line 100 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 6776, i, 6776, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 6779, "\"", 6795, 2);
            WriteAttributeValue("", 6787, "Trang", 6787, 5, true);
#nullable restore
#line 100 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue(" ", 6792, i, 6793, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 100 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                                                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 101 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 7012, "\"", 7050, 4);
            WriteAttributeValue("", 7019, "?keyword=", 7019, 9, true);
#nullable restore
#line 104 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 7028, Model.Keyword, 7028, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7042, "&page=", 7042, 6, true);
#nullable restore
#line 104 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 7048, i, 7048, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 7051, "\"", 7067, 2);
            WriteAttributeValue("", 7059, "Trang", 7059, 5, true);
#nullable restore
#line 104 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue(" ", 7064, i, 7065, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 104 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 105 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                 if (Model.Page < Model.TotalPages)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 7380, "\"", 7431, 4);
            WriteAttributeValue("", 7387, "?keyword=", 7387, 9, true);
#nullable restore
#line 110 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 7396, Model.Keyword, 7396, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7410, "&page=", 7410, 6, true);
#nullable restore
#line 110 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 7416, Model.Page+1, 7416, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                                            <i class=\"fa fa-angle-double-right\"></i>\r\n                                        </a>\r\n                                    </li>\r\n");
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 7750, "\"", 7803, 4);
            WriteAttributeValue("", 7757, "?keyword=", 7757, 9, true);
#nullable restore
#line 116 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 7766, Model.Keyword, 7766, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7780, "&page=", 7780, 6, true);
#nullable restore
#line 116 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
WriteAttributeValue("", 7786, Model.TotalPages, 7786, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Last\">\r\n                                            <i class=\"fa fa-angle-double-right\"></i>\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 120 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </nav>\r\n");
#nullable restore
#line 123 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--end main body-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DuHoc.ViewModels.Common.PaginationSet<DuHoc.Models.School>> Html { get; private set; }
    }
}
#pragma warning restore 1591
