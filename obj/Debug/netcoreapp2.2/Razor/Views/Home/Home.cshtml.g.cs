#pragma checksum "/Users/nhannguyen/Desktop/cinemapandasUpdate/Views/Home/Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d86f24fd48bafc8a431053bf58801e52876a6971"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "/Users/nhannguyen/Desktop/cinemapandasUpdate/Views/_ViewImports.cshtml"
using cinemapandas;

#line default
#line hidden
#line 2 "/Users/nhannguyen/Desktop/cinemapandasUpdate/Views/_ViewImports.cshtml"
using cinemapandas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d86f24fd48bafc8a431053bf58801e52876a6971", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1415ae5d38f97e56097c2ba92b3d349c4d3c63e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 135, true);
            WriteLiteral("\n<div class=\"jumbotron red-panda\">\n    <h1>Cinema Pandas are coming soon...</h1>\n</div>\n<a href=\"/logout\">Log out</a>\n<hr>\n<h1>Welcome ");
            EndContext();
            BeginContext(155, 17, false);
#line 8 "/Users/nhannguyen/Desktop/cinemapandasUpdate/Views/Home/Home.cshtml"
       Write(ViewBag.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(172, 282, true);
            WriteLiteral(@"!</h1>

<table class=""table border border-danger"">
    <thead class=""bg-danger text-light"">
        <th>Title</th>
        <th>Genre</th>
        <th>Release Year</th>
        <th>Screen Start Time</th>
        <th># of Guests</th>
        <th>Actions</th>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "/Users/nhannguyen/Desktop/cinemapandasUpdate/Views/Home/Home.cshtml"
         foreach (Movie m in Model)
        {

#line default
#line hidden
            BeginContext(500, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(538, 7, false);
#line 23 "/Users/nhannguyen/Desktop/cinemapandasUpdate/Views/Home/Home.cshtml"
               Write(m.Title);

#line default
#line hidden
            EndContext();
            BeginContext(545, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(572, 7, false);
#line 24 "/Users/nhannguyen/Desktop/cinemapandasUpdate/Views/Home/Home.cshtml"
               Write(m.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(579, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(606, 6, false);
#line 25 "/Users/nhannguyen/Desktop/cinemapandasUpdate/Views/Home/Home.cshtml"
               Write(m.Year);

#line default
#line hidden
            EndContext();
            BeginContext(612, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(639, 34, false);
#line 26 "/Users/nhannguyen/Desktop/cinemapandasUpdate/Views/Home/Home.cshtml"
               Write(m.ScreeningTime.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(673, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(675, 2, true);
            WriteLiteral("@ ");
            EndContext();
            BeginContext(678, 35, false);
#line 26 "/Users/nhannguyen/Desktop/cinemapandasUpdate/Views/Home/Home.cshtml"
                                                      Write(m.ScreeningTime.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(713, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(740, 14, false);
#line 27 "/Users/nhannguyen/Desktop/cinemapandasUpdate/Views/Home/Home.cshtml"
               Write(m.Guests.Count);

#line default
#line hidden
            EndContext();
            BeginContext(754, 678, true);
            WriteLiteral(@"</td>
                <td>
                    if(ViewBag.User.UserId == m.Organizer.UserId)
                    {
                    <a class=""btn btn-warning"">Cancel</a>
                    }
                    else
                    {
                    // Query to see if they are watching
                    if(m.Guests.Any(w => w.UserId == ViewBag.User.userId))
                    {
                    <a class=""btn btn-outline-dark"">Back Out</a>
                    }
                    else
                    {
                    <a class=""btn btn-outline-success"">RSVP</a>
                    }
                    }
                </td>
            </tr>
");
            EndContext();
#line 47 "/Users/nhannguyen/Desktop/cinemapandasUpdate/Views/Home/Home.cshtml"
        }

#line default
#line hidden
            BeginContext(1442, 21, true);
            WriteLiteral("    </tbody>\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
