#pragma checksum "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4adfa6b0764f5eabc6a289159e9f90367a9b7f5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_Detail), @"mvc.1.0.view", @"/Views/School/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4adfa6b0764f5eabc6a289159e9f90367a9b7f5c", @"/Views/School/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3557f3a82d624f9477e00fbd975738ed8f3353f", @"/Views/_ViewImports.cshtml")]
    public class Views_School_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DuHoc.ViewModels.School.SchoolViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://vjvietnam.com.vn/wp-comments-post.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("commentform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""beacrum"">
    <div class=""container"">
        <ul class=""clearfix bdc_box""><li><a href=""/"">Trang chủ</a></li> <li class=""separator"">&rsaquo;</li> <li><a href=""/du-hoc-nhat-ban/2"">Du học nhật bản</a> <li class=""separator"">&rsaquo;</li> </li><li class=""current"">");
#nullable restore
#line 8 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
                                                                                                                                                                                                                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li></ul>\r\n    </div>\r\n</div>\r\n<div class=\"cat_du_hoc\">\r\n    <div class=\"container\">\r\n        <h1 class=\"dhs_title\">");
#nullable restore
#line 13 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p class=\"view_single\">Lượt người xem : ");
#nullable restore
#line 14 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
                                           Write(Model.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""album"">
                    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script> <!-- 33 KB -->
                    <link href=""https://cdnjs.cloudflare.com/ajax/libs/fotorama/4.6.4/fotorama.css"" rel=""stylesheet""> <!-- 3 KB -->
                    <script src=""https://cdnjs.cloudflare.com/ajax/libs/fotorama/4.6.4/fotorama.js""></script> <!-- 16 KB -->
                    <div class=""fotorama"" data-nav=""thumbs"" data-width=""100%"" data-height=""auto"">
");
#nullable restore
#line 22 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
                         if (Model.Images != null && Model.Image.Count() > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1302, "\"", 1321, 1);
#nullable restore
#line 24 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
WriteAttributeValue("", 1309, Model.Image, 1309, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1361, "\"", 1379, 1);
#nullable restore
#line 25 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
WriteAttributeValue("", 1367, Model.Image, 1367, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"100\" data-caption=\"");
#nullable restore
#line 25 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
                                                                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            </a>\r\n");
#nullable restore
#line 27 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
                            foreach (var item in Model.Images)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1598, "\"", 1615, 1);
#nullable restore
#line 29 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
WriteAttributeValue("", 1605, item.Path, 1605, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1659, "\"", 1675, 1);
#nullable restore
#line 30 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
WriteAttributeValue("", 1665, item.Path, 1665, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"100\" data-caption=\"");
#nullable restore
#line 30 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
                                                                                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                </a>\r\n");
#nullable restore
#line 32 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <div class=\"single_mt\">\r\n                    ");
#nullable restore
#line 40 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
               Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"box_intro_content\">\r\n            ");
#nullable restore
#line 45 "D:\nghia\DoAnTotNghiep2022\Vân\DuHoc\DuHoc\Views\School\Detail.cshtml"
       Write(Html.Raw(Model.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""dhhq pagebox"">
    <div class=""container"">
        <h2 class=""taxo_title""><span>Cảm nhận học viên</span></h2>
        <div class=""owl-carousel cnhv"">
        </div>
    </div>
</div> <div class=""comment"">
    <div class=""container"">
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

.comment-meta.commentmeta");
            WriteLiteral(@"data a {
    color: #777;
    font-size: 12px;
    font-style: italic;
}

.reply a {
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
    wi");
            WriteLiteral(@"dth: 40% !important;
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

.comment-");
            WriteLiteral(@"author.vcard img {
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
p.save_text input {
    margin-right: 5px;
}
div#respond {
    border-top: 1px solid #ccc;
    padding: 15px 0;
}
        </style>
        <!-- If comments are open, but there are no comments. -->

        <div id=""respond"">
            <p>Chia sẻ nhận xét của bạn</p>
            <p>Nhận xét của bạn *</p>
            <div class=""cancel-comment-reply"">
                <a rel=""nofollow"" id=""cancel-comment-reply-link"" href=""/truong-nhat-ngu-musashi-urawa/#respond"" style=""display:none;"">Nhấp chuột vào đây để hủy trả lời.</a>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4adfa6b0764f5eabc6a289159e9f90367a9b7f5c14379", async() => {
                WriteLiteral("\r\n\r\n                <div>\r\n                    <textarea name=\"comment\" id=\"comment\" cols=\"58\" rows=\"10\" tabindex=\"4\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6336, "\"", 6350, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n                </div>\r\n                <div class=\"cm_name\">\r\n                    <label>Tên *</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"author\" id=\"author\"");
                BeginWriteAttribute("value", " value=\"", 6555, "\"", 6563, 0);
                EndWriteAttribute();
                WriteLiteral(@" size=""22"" tabindex=""1"" aria-required='true' placeholder=""Name"" />
                </div>
                <div class=""clearfix""></div>
                <div class=""cm_email"">
                    <label>Email *</label>
                    <input type=""text"" class=""form-control"" name=""email"" id=""email""");
                BeginWriteAttribute("value", " value=\"", 6869, "\"", 6877, 0);
                EndWriteAttribute();
                WriteLiteral(@" size=""22"" tabindex=""2"" aria-required='true' placeholder=""E-mail"" />
                </div>
                <!--<p>You can use these tags: <code></code></p> -->
                <p class=""save_text"">
                    <input type=""checkbox"" name=""save_text"">Lưu tên của tôi, email trong trình duyệt này cho lần bình luận kế tiếp
                </p>
                <div class=""clearfix""></div>
                <div>
                    <input name=""submit"" type=""submit"" id=""submit"" tabindex=""5"" value=""Gửi đi"" />
                    <input type='hidden' name='comment_post_ID' value='1718' id='comment_post_ID' />
                    <input type='hidden' name='comment_parent' id='comment_parent' value='0' />
                </div>


            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        </div>
    </div>
</div>
<link rel=""stylesheet"" href=""https://vjvietnam.com.vn/wp-content/themes/default/css/owl.carousel.min.css"">
<script src=""https://vjvietnam.com.vn/wp-content/themes/default/js/owl.carousel.min.js""></script>
<script>
    jQuery(document).ready(function ($) {


        $('.cnhv').owlCarousel({
            loop: true, margin: 20, nav: true, autoplay: true, autoplayTimeout: 5000, autoplayHoverPause: true,
            responsive: { 0: { items: 1 }, 480: { items: 1 }, 1000: { items: 2, nav: true } }
        });
        $("".owl-prev"").html('<i class=""fa fa-angle-left""></i>');
        $("".owl-next"").html('<i class=""fa fa-angle-right""></i>');

    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DuHoc.ViewModels.School.SchoolViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
