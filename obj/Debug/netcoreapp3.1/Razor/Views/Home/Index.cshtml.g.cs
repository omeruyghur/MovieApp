#pragma checksum "C:\Users\sawap\Desktop\omer\MovieApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f5e69d5a7a8822f7e645c47a7772c13b90a57e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\sawap\Desktop\omer\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sawap\Desktop\omer\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sawap\Desktop\omer\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f5e69d5a7a8822f7e645c47a7772c13b90a57e9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b95e5643657a0880ddf393c75cb7dfd16b765f07", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeMovieModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- content -->\r\n\r\n");
            WriteLiteral("<!-- home -->\r\n<div>\r\n\r\n\t");
#nullable restore
#line 11 "C:\Users\sawap\Desktop\omer\MovieApp\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_slyte",Model.HomeSlyderModel));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<!-- end home -->
<section class=""content"">
	<div class=""content__head"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-12"">
					<!-- content title -->
					<h2 class=""content__title"">New items</h2>
					<!-- end content title -->

					<!-- content tabs nav -->
					<ul class=""nav nav-tabs content__tabs"" id=""content__tabs"" role=""tablist"">
						<li class=""nav-item"">
							<a class=""nav-link active"" data-toggle=""tab"" href=""#tab-1"" role=""tab"" aria-controls=""tab-1""
								aria-selected=""true"">NEW RELEASES</a>
						</li>

						<li class=""nav-item"">
							<a class=""nav-link"" data-toggle=""tab"" href=""#tab-2"" role=""tab"" aria-controls=""tab-2""
								aria-selected=""false"">MOVIES</a>
						</li>

						<li class=""nav-item"">
							<a class=""nav-link"" data-toggle=""tab"" href=""#tab-3"" role=""tab"" aria-controls=""tab-3""
								aria-selected=""false"">TV SERIES</a>
						</li>

						<li class=""nav-item"">
							<a class=""nav-link"" data-toggle=""tab"" href=""#tab-4""");
            WriteLiteral(@" role=""tab"" aria-controls=""tab-4""
								aria-selected=""false"">CARTOONS</a>
						</li>
					</ul>
					<!-- end content tabs nav -->

					<!-- content mobile tabs nav -->
					<div class=""content__mobile-tabs"" id=""content__mobile-tabs"">
						<div class=""content__mobile-tabs-btn dropdown-toggle"" role=""navigation"" id=""mobile-tabs""
							data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
							<input type=""button"" value=""New items"">
							<span></span>
						</div>

						<div class=""content__mobile-tabs-menu dropdown-menu"" aria-labelledby=""mobile-tabs"">
							<ul class=""nav nav-tabs"" role=""tablist"">
								<li class=""nav-item""><a class=""nav-link active"" id=""1-tab"" data-toggle=""tab""
										href=""#tab-1"" role=""tab"" aria-controls=""tab-1"" aria-selected=""true"">NEW
										RELEASES</a></li>

								<li class=""nav-item""><a class=""nav-link"" id=""2-tab"" data-toggle=""tab"" href=""#tab-2""
										role=""tab"" aria-controls=""tab-2"" aria-selected=""false"">MOVIES</a></li>

		");
            WriteLiteral(@"						<li class=""nav-item""><a class=""nav-link"" id=""3-tab"" data-toggle=""tab"" href=""#tab-3""
										role=""tab"" aria-controls=""tab-3"" aria-selected=""false"">TV SERIES</a></li>

								<li class=""nav-item""><a class=""nav-link"" id=""4-tab"" data-toggle=""tab"" href=""#tab-4""
										role=""tab"" aria-controls=""tab-4"" aria-selected=""false"">CARTOONS</a></li>
							</ul>
						</div>
					</div>
					<!-- end content mobile tabs nav -->
				</div>
			</div>
		</div>
	</div>


	<div class=""container"">
		<!-- content tabs -->
		<div class=""tab-content"" id=""myTabContent"">
			<div class=""tab-pane fade show active"" id=""tab-1"" role=""tabpanel"" aria-labelledby=""1-tab"">
				<div class=""row"">
");
            WriteLiteral("\t\t\t\t\t");
#nullable restore
#line 85 "C:\Users\sawap\Desktop\omer\MovieApp\Views\Home\Index.cshtml"
               Write(await Html.PartialAsync("_movie",Model.HomePageModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<!-- end content tabs -->\r\n\t</div>\r\n\r\n\r\n</section>\r\n<!-- end content -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeMovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591