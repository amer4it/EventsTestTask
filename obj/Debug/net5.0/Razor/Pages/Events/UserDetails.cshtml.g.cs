#pragma checksum "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0dc00f7b6d26ead19fb89c4d3a3d901c5e32779"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EventsApp.Pages.Events.Pages_Events_UserDetails), @"mvc.1.0.razor-page", @"/Pages/Events/UserDetails.cshtml")]
namespace EventsApp.Pages.Events
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
#line 1 "C:\Users\User\source\repos\EventsApp\Pages\_ViewImports.cshtml"
using EventsApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0dc00f7b6d26ead19fb89c4d3a3d901c5e32779", @"/Pages/Events/UserDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877b22bda9e16224cf9a6ce3efc8f0519ef93b9b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Events_UserDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Events/UserEvents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
  
    ViewData["Title"] = "Event Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>Event Details</h1>\r\n\r\n<div>\r\n    <h4>Event</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
       Write(Html.DisplayFor(model => model.Event.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
       Write(Html.DisplayFor(model => model.Event.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
       Write(Html.DisplayFor(model => model.Event.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.CoordLongitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
       Write(Html.DisplayFor(model => model.Event.CoordLongitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.CoordLatitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
       Write(Html.DisplayFor(model => model.Event.CoordLatitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
       Write(Html.DisplayFor(model => model.Event.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            Related Events :\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <ul>\r\n");
#nullable restore
#line 58 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
                 foreach (var r in Model.relatedEventsList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        ");
#nullable restore
#line 61 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
                    Write(r);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 63 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
            WriteLiteral("        </dd>\r\n");
            WriteLiteral("\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Event.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 2332, "\"", 2387, 2);
            WriteAttributeValue("", 2338, "/", 2338, 1, true);
#nullable restore
#line 78 "C:\Users\User\source\repos\EventsApp\Pages\Events\UserDetails.cshtml"
WriteAttributeValue("", 2339, Html.DisplayFor(model => model.Event.ImagePath), 2339, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\" />\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0dc00f7b6d26ead19fb89c4d3a3d901c5e327799222", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventsApp.Pages.Events.UserDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EventsApp.Pages.Events.UserDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EventsApp.Pages.Events.UserDetailsModel>)PageContext?.ViewData;
        public EventsApp.Pages.Events.UserDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
