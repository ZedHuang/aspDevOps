#pragma checksum "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b282a8ed13b1001da368ab00c78177727a5fb45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Age), @"mvc.1.0.view", @"/Views/Home/Age.cshtml")]
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
#line 1 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\_ViewImports.cshtml"
using adminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\_ViewImports.cshtml"
using adminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b282a8ed13b1001da368ab00c78177727a5fb45", @"/Views/Home/Age.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2012e0b0b972ab350419e70e8fc2d19cadb8a09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Age : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
  
	ViewBag.Title = "Age analysis";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 6 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
  
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b282a8ed13b1001da368ab00c78177727a5fb453709", async() => {
                WriteLiteral("\n\t<meta name=\"viewport\" content=\"width=device-width\" />\n\t<script type=\"text/javascript\" src=\"https://canvasjs.com/assets/script/canvasjs.min.js\"></script>\n\t<title>Age analysis</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b282a8ed13b1001da368ab00c78177727a5fb454868", async() => {
                WriteLiteral(@"
	
	<br /><br />
	<br />
	<br />
	<br />
	<br />

	<div id=""chartContainer2""></div>

	<script type=""text/javascript"">

		window.onload = function () {
			var chart = new CanvasJS.Chart(""chartContainer2"", {
				theme: ""light2"",
				animationEnabled: true,
				title: {
					text: ""Comparison of the average rating among age groups""
				},
				data: [
					{
						type: ""column"",
						dataPoints: [
                            { y: ");
#nullable restore
#line 41 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
                            Write(ViewBag.ages[0].rate);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"");
#nullable restore
#line 41 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
                                                           Write(ViewBag.ages[0].age);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" },\n                            { y: ");
#nullable restore
#line 42 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
                            Write(ViewBag.ages[1].rate);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"");
#nullable restore
#line 42 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
                                                           Write(ViewBag.ages[1].age);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" },\n                            { y: ");
#nullable restore
#line 43 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
                            Write(ViewBag.ages[2].rate);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"");
#nullable restore
#line 43 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
                                                           Write(ViewBag.ages[2].age);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" },\n                            { y: ");
#nullable restore
#line 44 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
                            Write(ViewBag.ages[3].rate);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"");
#nullable restore
#line 44 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
                                                           Write(ViewBag.ages[3].age);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" },\n                            { y: ");
#nullable restore
#line 45 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
                            Write(ViewBag.ages[4].rate);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"");
#nullable restore
#line 45 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
                                                           Write(ViewBag.ages[4].age);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" },\n\t\t\t\t\t\t\t{ y: ");
#nullable restore
#line 46 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
                            Write(ViewBag.ages[5].rate);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"");
#nullable restore
#line 46 "C:\Users\huang\Desktop\aspDevOps-master\aspDevOps-master\adminApp\Views\Home\Age.cshtml"
                                                           Write(ViewBag.ages[5].age);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" },\n\t\t\t\t\t\t]\n\t\t\t\t\t}\n\t\t\t\t]\n\t\t\t});\n\t\t\tchart.render();\n\t\t};\n\t</script>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
