#pragma checksum "E:\GitHub\FileManager\FileManager\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aa20e41778b13894e0955712aed8b5c10a27f50"
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
#line 1 "E:\GitHub\FileManager\FileManager\Views\_ViewImports.cshtml"
using FileManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GitHub\FileManager\FileManager\Views\_ViewImports.cshtml"
using FileManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aa20e41778b13894e0955712aed8b5c10a27f50", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37eba4d15a433058bfdf2a887db7df4f48a8815", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sidebar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Animate.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/UpImage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\GitHub\FileManager\FileManager\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0aa20e41778b13894e0955712aed8b5c10a27f505417", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0aa20e41778b13894e0955712aed8b5c10a27f506593", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0aa20e41778b13894e0955712aed8b5c10a27f507769", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""card"">
	<div class=""card-header"">
		<ul>
			<li>
				<button class=""btn btn-md btn-light border border-secondary"" id=""btnsidebar"">
					<i class=""fas fa-bars""></i>
					<p>Thu gọn</p>
				</button>
				<button class=""btn btn-md btn-light border border-secondary"" id=""btnNew"">
					<i class=""fas fa-folder-plus""></i>
					<p>Tạo mới</p>
				</button>
				<button class=""css-btn btn btn-md btn-light border-secondary css-display"">
					<i class=""fas fa-eye""></i>
					<p>Xem</p>
				</button>
				<button class=""css-btn btn btn-md btn-light border-secondary css-display"">
					<i class=""fas fa-download""></i>
					<p>Tải về</p>
				</button>
				<button class=""css-btn btn btn-md btn-light border-secondary css-display"">
					<i class=""fas fa-edit""></i>
					<p>Sửa</p>
				</button>
				<button class=""css-btn btn btn-md btn-light border-secondary css-display"">
					<i class=""fas fa-copy""></i>
					<p>Copy</p>
				</button>
				<button class=""css-btn btn btn-md btn-light border-se");
            WriteLiteral(@"condary css-display"">
					<i class=""fas fa-file-export""></i>
					<p>Di chuyển</p>
				</button>
				<button class=""css-btn btn btn-md btn-light border-secondary css-display"">
					<i class=""fas fa-info-circle""></i>
					<p>Đổi tên</p>
				</button>
				<button class=""css-btn btn btn-md btn-light border-secondary css-display"">
					<i class=""fas fa-trash-alt""></i>
					<p>Xóa</p>
				</button>
				<div class=""form-inline css-display"" id=""css-form"">
					<input type=""text"" name=""picture"" id=""picture"" class=""form-control"" style=""display: none;"" />
					<input type=""file"" name=""fileUpload"" accept=""image/*"" id=""fileUpload"" style=""display: none;"" />
					<button type=""button"" class=""btn btn-md btn-light border-secondary"" id=""btnUpload"">
						<i class=""fas fa-upload""></i>
						Tải lên
					</button>
				</div>
			</li>
		</ul>
");
            WriteLiteral(@"
		<!--Tìm Kiếm-->
		<div class=""input-group rounded css-search"">
			<input type=""search"" class=""form-control rounded"" placeholder=""Search"" aria-label=""Search""
				   aria-describedby=""search-addon"" />
			<button class=""btn btn-light"">
				<i class=""fas fa-cog""></i>
			</button>
		</div>
	</div>
	<div class=""card-body"">
		<div class=""js-slide"">
			<nav id=""sidebar"">
				<ul class=""lisst-unstyled components"">
					<li class=""border-li"">
						<a href=""#"">
							<i class=""fas fa-folder text-primary""></i>
							file
						</a>
						<i href=""#submenu1"" data-toggle=""collapse"" aria-expanded=""false"" class=""fas fa-caret-down"" id=""icon""></i>
						<ul class=""collapse lisst-unstyled"" id=""submenu1"">
							<li class=""li-item"">
								<a href=""#"">file1</a>
							</li>
							<li class=""li-item"">
								<a href=""#"">file2</a>
							</li>
							<li class=""li-item"">
								<a href=""#"">file3</a>
							</li>
						</ul>
					</li>
					<li class=""border-li"">
						<a href=""#"">
						");
            WriteLiteral(@"	<i class=""fas fa-folder text-primary""></i>
							file
						</a>
						<i href=""#submenu2"" data-toggle=""collapse"" aria-expanded=""false"" class=""fas fa-caret-down""></i>

						<ul class=""collapse lisst-unstyled"" id=""submenu2"">
							<li class=""li-item"">
								
								<a href=""#"">
									<i class=""fas fa-folder text-primary""></i>
									file1
								</a>
							</li>
							<li class=""li-item"">
								
								<a href=""#"">
									<i class=""fas fa-folder text-primary""></i>
									file2
								</a>
							</li>
							<li class=""li-item"">
								
								<a href=""#"">
									<i class=""fas fa-folder text-primary""></i>
									file3
								</a>
							</li>
						</ul>
					</li>
					<li class=""border-li"">
						<a href=""#"">
							<i class=""fas fa-folder text-primary""></i>
							file
						</a>
						<i href=""#submenu3"" data-toggle=""collapse"" aria-expanded=""false"" class=""fas fa-caret-down""></i>

						<ul class=""collapse lisst-unstyled"" id=""submenu3"">
				");
            WriteLiteral(@"			<li class=""li-item"">
								<a href=""#"">file1</a>
							</li>
							<li class=""li-item"">
								<a href=""#"">file2</a>
							</li>
							<li class=""li-item"">
								<a href=""#"">file3</a>
							</li>
						</ul>
					</li>
					<li class=""border-li"">
						<a href=""#"">
							<i class=""fas fa-folder text-primary""></i>
							file
						</a>
						<i href=""#submenu4"" data-toggle=""collapse"" aria-expanded=""false"" class=""fas fa-caret-down""></i>

						<ul class=""collapse lisst-unstyled"" id=""submenu4"">
							<li class=""li-item"">
								<a href=""#"">file1</a>
							</li>
							<li class=""li-item"">
								<a href=""#"">file2</a>
							</li>
							<li class=""li-item"">
								<a href=""#"">file3</a>
							</li>
						</ul>
					</li>
				</ul>
			</nav>
		</div>
		<div class=""css-content js-content"">
		</div>
	</div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aa20e41778b13894e0955712aed8b5c10a27f5014263", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aa20e41778b13894e0955712aed8b5c10a27f5015361", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
