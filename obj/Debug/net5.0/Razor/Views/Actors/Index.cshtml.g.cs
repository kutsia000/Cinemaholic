#pragma checksum "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Actors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86ac7bce97726decdd230dc0499a4f09941ec2c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actors_Index), @"mvc.1.0.view", @"/Views/Actors/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86ac7bce97726decdd230dc0499a4f09941ec2c8", @"/Views/Actors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e9e4bcac7067345e0aba9c65e8c3f54f52ae78", @"/Views/_ViewImports.cshtml")]
    public class Views_Actors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Actor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Actors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" />
<div class=""d-flex"">
    <div class=""col-sm-12 col-md-12 col-lg-12"">
        <div class=""row"">
            <div class=""col-sm-12 col-md-12 col-lg-12"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86ac7bce97726decdd230dc0499a4f09941ec2c83939", async() => {
                WriteLiteral("დამატება");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                        <h3>გაფილტვრა</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""row"">
                            <label class=""col-form-label"">სახელი:</label>
                            <input class=""form-control"" id=""name"" />
                        </div>
                        <div class=""row"">
                            <label");
            BeginWriteAttribute("class", " class=\"", 948, "\"", 956, 0);
            EndWriteAttribute();
            WriteLiteral(@">გვარი:</label>
                            <input class=""form-control"" id=""lastname"" />
                        </div>
                        <div class=""row"">
                            <label class=""col-form-label"">წლიდან: <span id=""spanyearfrom""></span></label>
                            <input class=""form-control"" type=""range"" min=""1800"" max=""2022"" value=""1800"" id=""yearfrom"" />
                        </div>
                        <div class=""row"">
                            <label class=""col-form-label"">წლამდე: <span id=""spanyearto""></span></label>
                            <input class=""form-control"" type=""range"" min=""1800"" max=""2022"" value=""2022"" id=""yearto"" />
                        </div>
                        <div class=""row"">
                            <label class=""col-form-label"">რეიტინგი(დან): <span id=""spanratingfrom""></span></label>
                            <input class=""form-control"" type=""range"" min=""0"" max=""10"" value=""0"" id=""ratingfrom"" />
                      ");
            WriteLiteral(@"  </div>
                        <div class=""row"">
                            <label class=""col-form-label"">რეიტინგი(მდე): <span id=""spanratingto""></span></label>
                            <input class=""form-control"" type=""range"" min=""0"" max=""10"" value=""10"" id=""ratingto"" />
                        </div>
                    </div>
                    <div class=""card-footer"">
                        <button type=""button"" id=""btnsubmit"" class=""btn btn-info"" style=""float:right;"">ძებნა</button>
                    </div>
                </div>
            </div>
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-9"">
                <div class=""d-flex"">
");
#nullable restore
#line 47 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Actors\Index.cshtml"
                     foreach (var item in Model)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-12 col-sm-6 col-lg-3\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2834, "\"", 2862, 2);
            WriteAttributeValue("", 2841, "Actors/Actor/", 2841, 13, true);
#nullable restore
#line 51 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Actors\Index.cshtml"
WriteAttributeValue("", 2854, item.Id, 2854, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"" style=""cursor:pointer"">
                                <div class=""single_advisor_profile wow fadeInUp"" data-wow-delay=""0.5s"" style=""visibility: visible; animation-delay: 0.5s; animation-name: fadeInUp;"">
                                    <!-- Team Thumb-->
                                    <div class=""advisor_thumb"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 3253, "\"", 3272, 1);
#nullable restore
#line 55 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Actors\Index.cshtml"
WriteAttributeValue("", 3259, item.ImgPath, 3259, 13, false);

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
#line 61 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Actors\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 61 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Actors\Index.cshtml"
                                                  Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p class=\"designation\">");
#nullable restore
#line 62 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Actors\Index.cshtml"
                                                          Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </a>\r\n                        </div>\r\n");
#nullable restore
#line 90 "C:\Users\gioku\source\repos\TestMVC\TestMVC\Views\Actors\Index.cshtml"
                                    
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>



<!--<div class=""container"">
    <div class=""row justify-content-center"">
        <div class=""col-12 col-sm-8 col-lg-6"">-->
<!-- Section Heading-->
<!--<div class=""section_heading text-center wow fadeInUp"" data-wow-delay=""0.2s"" style=""visibility: visible; animation-delay: 0.2s; animation-name: fadeInUp;"">
            <h3>Our Creative <span> Team</span></h3>
            <p>Appland is completely creative, lightweight, clean &amp; super responsive app landing page.</p>
            <div class=""line""></div>
        </div>
    </div>
</div>
<div class=""row"">-->
<!-- Single Advisor-->
<!--<div class=""col-12 col-sm-6 col-lg-3"">
    <div class=""single_advisor_profile wow fadeInUp"" data-wow-delay=""0.5s"" style=""visibility: visible; animation-delay: 0.5s; animation-name: fadeInUp;"">-->
<!-- Team Thumb-->
<!--<div class=""advisor_thumb"">
    <img src=""https://bootdey.com/img/Content/avatar/avatar2.png"" alt="""">-->
<!-- Soc");
            WriteLiteral(@"ial Info-->
<!--<div class=""social-info""><a href=""#""><i class=""fa fa-facebook""></i></a><a href=""#""><i class=""fa fa-twitter""></i></a><a href=""#""><i class=""fa fa-linkedin""></i></a></div>
</div>-->
<!-- Team Details-->
<!--<div class=""single_advisor_details_info"">
                    <h6>Niloy Islam</h6>
                    <p class=""designation"">Marketing Manager</p>
                </div>
            </div>
        </div>
    </div>
</div>-->

<script>
    //todo სერჩპარამეტრებიდან მიანიჭოს ინპუტებს მნიშვნელობები
    var slider = document.getElementById(""yearfrom"");
    var output = document.getElementById(""spanyearfrom"");
    output.innerHTML = slider.value;

    document.getElementById(""btnsubmit"").onclick = function () {
        alert(1)
        let name = document.getElementById(""name"").value;
        let lastname = document.getElementById(""lastname"").value;
        let yearfrom = document.getElementById(""yearfrom"").value;
        let yearto = document.getElementById(""yearto"").value");
            WriteLiteral(@";
        let ratingfrom = document.getElementById(""ratingfrom"").value;
        let ratingto = document.getElementById(""ratingto"").value;

        window.location.href = `Actors?name=${name}&lastname=${lastname}&yearfrom=${yearfrom}&yearto=${yearto}&ratingfrom=${ratingfrom}$ratingto=${ratingto}`;
    }

    var slider1 = document.getElementById(""yearto"");
    var output1 = document.getElementById(""spanyearto"");
    output1.innerHTML = slider1.value;

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
        output2.innerHTML = this.");
            WriteLiteral("value;\r\n    }\r\n    slider3.oninput = function () {\r\n        output3.innerHTML = this.value;\r\n    }\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Actor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
