#pragma checksum "F:\Visual Studio Repositories\AuctionSite\AuctionSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb087f6eba2f129790a2dc245ac371e7184e89d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "F:\Visual Studio Repositories\AuctionSite\AuctionSite\Views\_ViewImports.cshtml"
using AuctionSite;

#line default
#line hidden
#line 2 "F:\Visual Studio Repositories\AuctionSite\AuctionSite\Views\_ViewImports.cshtml"
using AuctionSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb087f6eba2f129790a2dc245ac371e7184e89d3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2173c236f12bad0923230709667d7e264e763f29", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/iphone.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 1631, true);
            WriteLiteral(@"<section class=""section-working"">
    <div class=""row"">
        <h3 class=""heading"" style=""text-align:center;"">How Auction works</h3>
    </div>
    <div class=""row working-div"">
        <div class=""col-md-3 text-center working"">
            <i class=""glyphicon glyphicon-pencil working-logo""></i>
            <br />
            <h4>Register free</h4>
            First of all Register yourself in Auction to get started...
        </div>
        <div class=""col-md-3 text-center working"">
            <i class=""glyphicon glyphicon-shopping-cart working-logo""></i>
            <br />
            <h4>Choose an Auction</h4>
            choose from our products, a laptop, credits, 3D TV or Xbox One
        </div>
        <div class=""col-md-3 text-center working"">
            <i class=""glyphicon glyphicon-euro working-logo""></i>
            <br />
            <h4>Bid &amp; Win</h4>
            The price increases with every bid by &euro; 0.01. Bid and Win that auction.
        </div>
        <div ");
            WriteLiteral(@"class=""col-md-3 text-center working"">
            <i class=""glyphicon glyphicon-home working-logo""></i>
            <br />
            <h4>Free Home Delivery</h4>
            Yes pays no shipping costs
        </div>
    </div>
</section>

<div class=""timer""></div>

<section class=""section-auction"">
    <div sty class=""row heading"">
        <h3 style=""text-align:center;"">The Auction Site where you always win!</h3>
    </div>
    <div class=""row auction-div text-center"">
        <div class=""col-sm-6 col-md-3"">
            <div style=""padding:10px;"" class=""thumbnail"">
                ");
            EndContext();
            BeginContext(1631, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c8fd5dfd9874af4911a363049f46fe8", async() => {
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
            EndContext();
            BeginContext(1672, 508, true);
            WriteLiteral(@"
                <div class=""caption"">
                    <h4>Samsung Galaxy S10 512 GB</h4>

                    <div style=""margin-left:85px;"" class=""timer-quick"" data-seconds-left=""70""></div>

                    <h3>&euro; 947</h3>
                    <p><a href=""#"" class=""btn btn-primary"" role=""button"">Bid</a></p>
                </div>
            </div>
        </div>

        <div class=""col-sm-6 col-md-3"">
            <div style=""padding:10px;"" class=""thumbnail"">
                ");
            EndContext();
            BeginContext(2180, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "32460615f164428c9b60840ed046a508", async() => {
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
            EndContext();
            BeginContext(2221, 508, true);
            WriteLiteral(@"
                <div class=""caption"">
                    <h4>Samsung Galaxy S10 512 GB</h4>

                    <div style=""margin-left:85px;"" class=""timer-quick"" data-seconds-left=""70""></div>

                    <h3>&euro; 947</h3>
                    <p><a href=""#"" class=""btn btn-primary"" role=""button"">Bid</a></p>
                </div>
            </div>
        </div>

        <div class=""col-sm-6 col-md-3"">
            <div style=""padding:10px;"" class=""thumbnail"">
                ");
            EndContext();
            BeginContext(2729, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f9cf4bd5391945cbb3279414809e61d9", async() => {
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
            EndContext();
            BeginContext(2770, 508, true);
            WriteLiteral(@"
                <div class=""caption"">
                    <h4>Samsung Galaxy S10 512 GB</h4>

                    <div style=""margin-left:85px;"" class=""timer-quick"" data-seconds-left=""70""></div>

                    <h3>&euro; 947</h3>
                    <p><a href=""#"" class=""btn btn-primary"" role=""button"">Bid</a></p>
                </div>
            </div>
        </div>

        <div class=""col-sm-6 col-md-3"">
            <div style=""padding:10px;"" class=""thumbnail"">
                ");
            EndContext();
            BeginContext(3278, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "338e9ac1dcf749d1a0dff9222b4ffe71", async() => {
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
            EndContext();
            BeginContext(3319, 508, true);
            WriteLiteral(@"
                <div class=""caption"">
                    <h4>Samsung Galaxy S10 512 GB</h4>

                    <div style=""margin-left:85px;"" class=""timer-quick"" data-seconds-left=""70""></div>

                    <h3>&euro; 947</h3>
                    <p><a href=""#"" class=""btn btn-primary"" role=""button"">Bid</a></p>
                </div>
            </div>
        </div>

        <div class=""col-sm-6 col-md-3"">
            <div style=""padding:10px;"" class=""thumbnail"">
                ");
            EndContext();
            BeginContext(3827, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "62657426e71a456a95df5bbdf26b4afc", async() => {
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
            EndContext();
            BeginContext(3868, 507, true);
            WriteLiteral(@"
                <div class=""caption"">
                    <h4>Samsung Galaxy S9 512 GB</h4>

                    <div style=""margin-left:85px;"" class=""timer-quick"" data-seconds-left=""70""></div>

                    <h3>&euro; 947</h3>
                    <p><a href=""#"" class=""btn btn-primary"" role=""button"">Bid</a></p>
                </div>
            </div>
        </div>

        <div class=""col-sm-6 col-md-3"">
            <div style=""padding:10px;"" class=""thumbnail"">
                ");
            EndContext();
            BeginContext(4375, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1fe3fd4d7bee41a4a99ae3e4cc7c6b87", async() => {
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
            EndContext();
            BeginContext(4416, 508, true);
            WriteLiteral(@"
                <div class=""caption"">
                    <h4>Samsung Galaxy S10 512 GB</h4>

                    <div style=""margin-left:85px;"" class=""timer-quick"" data-seconds-left=""70""></div>

                    <h3>&euro; 947</h3>
                    <p><a href=""#"" class=""btn btn-primary"" role=""button"">Bid</a></p>
                </div>
            </div>
        </div>

        <div class=""col-sm-6 col-md-3"">
            <div style=""padding:10px;"" class=""thumbnail"">
                ");
            EndContext();
            BeginContext(4924, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "88d79e3be7b849328c75de1a4b5b2329", async() => {
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
            EndContext();
            BeginContext(4965, 508, true);
            WriteLiteral(@"
                <div class=""caption"">
                    <h4>Samsung Galaxy S10 512 GB</h4>

                    <div style=""margin-left:85px;"" class=""timer-quick"" data-seconds-left=""70""></div>

                    <h3>&euro; 947</h3>
                    <p><a href=""#"" class=""btn btn-primary"" role=""button"">Bid</a></p>
                </div>
            </div>
        </div>

        <div class=""col-sm-6 col-md-3"">
            <div style=""padding:10px;"" class=""thumbnail"">
                ");
            EndContext();
            BeginContext(5473, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "198d4385ab4044b895c834779fddd49f", async() => {
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
            EndContext();
            BeginContext(5514, 420, true);
            WriteLiteral(@"
                <div class=""caption"">
                    <h4>Samsung Galaxy S10 512 GB</h4>

                    <div style=""margin-left:85px;"" class=""timer-quick"" data-seconds-left=""80""></div>

                    <h3>&euro; 947</h3>
                    <p><a href=""#"" class=""btn btn-primary"" role=""button"">Bid</a></p>
                </div>
            </div>
        </div>
    </div>


</section>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5952, 404, true);
                WriteLiteral(@"
<script>
    $(function () {
        $('.timer-quick').startTimer();
    });

    var newYear = new Date();
    newYear = newYear.setSeconds(new.getSeconds() + 30);
    //newYear = new Date(newYear.getFullYear(), newYear.getMonth(), newYear.getDate(), newYear.getHours(), newYear.getMinutes() + 1, newYear.getSeconds());
    $('.timer').countdown({ until: newYear, format: 'MS' });
</script>
");
                EndContext();
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