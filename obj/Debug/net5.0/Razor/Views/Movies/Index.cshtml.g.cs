#pragma checksum "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "779d0dba9a7413f62b4e110c91a898ce11151289"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\_ViewImports.cshtml"
using TestMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\_ViewImports.cshtml"
using TestMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"779d0dba9a7413f62b4e110c91a898ce11151289", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e9e4bcac7067345e0aba9c65e8c3f54f52ae78", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"d-flex\">\r\n    <div class=\"col-sm-12 col-md-12 col-lg-12\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12 col-md-12 col-lg-12 mb-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "779d0dba9a7413f62b4e110c91a898ce111512894329", async() => {
                WriteLiteral("????????????????????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
            <div class=""col-xs-12 col-sm-12 col-md-3 col-lg-3"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3>???????????????????????????</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""row"">
                            <label class=""col-form-label"">??????????????????:</label>
                            <input class=""form-control"" id=""name"" />
                        </div>
                        <div class=""row"">
                            <label class=""col-form-label"">???????????????:</label>
                            <select id=""genre"" class=""form-control"" name=""Genre"">
");
#nullable restore
#line 29 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Movies\Index.cshtml"
                                 foreach (var item in ViewBag.Genres)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "779d0dba9a7413f62b4e110c91a898ce111512896829", async() => {
#nullable restore
#line 31 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Movies\Index.cshtml"
                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Movies\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Movies\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </select>
                        </div>
                        <div class=""row"">
                            <label class=""col-form-label"">RT From: <span id=""spanyearfrom""></span></label>
                            <input class=""form-control"" type=""range"" min=""0"" max=""10"" value=""0"" id=""rtratingfrom"" />
                        </div>

                        <div class=""row"">
                            <label class=""col-form-label"">RT to: <span id=""spanyearto""></span></label>
                            <input class=""form-control"" type=""range"" min=""0"" max=""10"" value=""10"" id=""rtratingto"" />
                        </div>
                        <div class=""row"">
                            <label class=""col-form-label"">IMDB ????????????????????????(?????????): <span id=""spanratingfrom""></span></label>
                            <input class=""form-control"" type=""range"" min=""0"" max=""10"" value=""0"" id=""ratingfrom"" />
                        </div>
                        <div class=""row"">");
            WriteLiteral(@"
                            <label class=""col-form-label"">IMDB ????????????????????????(?????????): <span id=""spanratingto""></span></label>
                            <input class=""form-control"" type=""range"" min=""0"" max=""10"" value=""10"" id=""ratingto"" />
                        </div>
                    </div>
                    <div class=""card-footer"">
                        <button type=""button"" id=""btnsubmit"" class=""btn btn-info"" style=""float:right;"">???????????????</button>
                    </div>
                </div>
            </div>
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-9"">
                <div class=""d-flex"">
");
#nullable restore
#line 60 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Movies\Index.cshtml"
                     foreach (var item in ViewBag.Movies)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-12 col-sm-6 col-lg-3\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3236, "\"", 3264, 2);
            WriteAttributeValue("", 3243, "Movies/Movie/", 3243, 13, true);
#nullable restore
#line 64 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Movies\Index.cshtml"
WriteAttributeValue("", 3256, item.Id, 3256, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"" style=""cursor:pointer"">
                                <div class=""single_advisor_profile wow fadeInUp"" data-wow-delay=""0.5s"" style=""visibility: visible; animation-delay: 0.5s; animation-name: fadeInUp;"">
                                    <!-- Team Thumb-->
                                    <div class=""advisor_thumb"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 3655, "\"", 3674, 1);
#nullable restore
#line 68 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Movies\Index.cshtml"
WriteAttributeValue("", 3661, item.ImgPath, 3661, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Img"" style=""width: 176px; height: 256px; object-fit: cover;"" />
                                        <!-- Social Info-->

                                    </div>
                                    <!-- Team Details-->
                                    <div class=""single_advisor_details_info"">
                                        <h6>");
#nullable restore
#line 74 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Movies\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p class=\"designation\">");
#nullable restore
#line 75 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Movies\Index.cshtml"
                                                          Write(item.IMDB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p class=\"designation\">");
#nullable restore
#line 76 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Movies\Index.cshtml"
                                                          Write(item.RT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </a>\r\n                        </div>\r\n");
#nullable restore
#line 81 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Movies\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>

<script>
    //todo ?????????????????????????????????????????????????????? ???????????????????????? ???????????????????????? ???????????????????????????????????????
    var slider = document.getElementById(""rtratingfrom"");
    var output = document.getElementById(""spanyearfrom"");
    output.innerHTML = slider.value;

    document.getElementById(""btnsubmit"").onclick = function () {
        //alert(1)
        let name = document.getElementById(""name"").value;
        let yearfrom = document.getElementById(""rtratingfrom"").value;
        let yearto = document.getElementById(""rtratingto"").value;
        let ratingfrom = document.getElementById(""ratingfrom"").value;
        let ratingto = document.getElementById(""ratingto"").value;

        window.location.href = `Movies?name=${name}&rtratingfrom=${yearfrom}&rtratingto=${yearto}&ratingfrom=${ratingfrom}&ratingto=${ratingto}`;
    }

    var slider1 = document.getElementById(""rtratingto"");
    var output1 = document.getElementById(""spanyearto"");
    output1.inne");
            WriteLiteral(@"rHTML = slider1.value;

    var slider2 = document.getElementById(""ratingfrom"");
    var output2 = document.getElementById(""spanratingfrom"");
    output2.innerHTML = slider2.value;

    var slider3 = document.getElementById(""ratingto"");
    var output3 = document.getElementById(""spanratingto"");
    output3.innerHTML = slider3.value;

    slider.oninput = function () {
        output.innerHTML = this.value;
    }
    slider1.oninput = function () {
        output1.innerHTML = this.value;
    }
    slider2.oninput = function () {
        output2.innerHTML = this.value;
    }
    slider3.oninput = function () {
        output3.innerHTML = this.value;
    }


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
