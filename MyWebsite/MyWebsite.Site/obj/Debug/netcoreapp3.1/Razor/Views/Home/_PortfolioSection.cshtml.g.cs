#pragma checksum "C:\Users\paul3077\source\repos\mywebsite\MyWebsite\MyWebsite.Site\Views\Home\_PortfolioSection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "035a1ab1c4b83e540b24364dcb6704c08a314c27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__PortfolioSection), @"mvc.1.0.view", @"/Views/Home/_PortfolioSection.cshtml")]
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
#line 1 "C:\Users\paul3077\source\repos\mywebsite\MyWebsite\MyWebsite.Site\Views\_ViewImports.cshtml"
using MyWebsite.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paul3077\source\repos\mywebsite\MyWebsite\MyWebsite.Site\Views\_ViewImports.cshtml"
using MyWebsite.Site.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"035a1ab1c4b83e540b24364dcb6704c08a314c27", @"/Views/Home/_PortfolioSection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"791860a6c2768d10074c3011daf625ee59976199", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__PortfolioSection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section id=""portfolio"" class=""section-bg"">
    <div class=""container"">

        <header class=""section-header"">
            <h3 class=""section-title"">Our Portfolio</h3>
        </header>

        <div class=""row"">
            <div class=""col-lg-12"">
                <ul id=""portfolio-flters"">
                    <li data-filter=""*"" class=""filter-active"">All</li>
                    <li data-filter="".filter-app"">App</li>
                    <li data-filter="".filter-card"">Card</li>
                    <li data-filter="".filter-web"">Web</li>
                </ul>
            </div>
        </div>

        <div class=""row portfolio-container"">

            <div class=""col-lg-4 col-md-6 portfolio-item filter-app wow fadeInUp"">
                <div class=""portfolio-wrap"">
                    <figure>
                        <img src=""images/portfolio/app1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 906, "\"", 912, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <a href=""images/portfolio/app1.jpg"" data-lightbox=""portfolio"" data-title=""App 1"" class=""link-preview"" title=""Preview""><i class=""ion ion-eye""></i></a>
                        <a href=""#"" class=""link-details"" title=""More Details""><i class=""ion ion-android-open""></i></a>
                    </figure>

                    <div class=""portfolio-info"">
                        <h4><a href=""#"">App 1</a></h4>
                        <p>App</p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 col-md-6 portfolio-item filter-web wow fadeInUp"" data-wow-delay=""0.1s"">
                <div class=""portfolio-wrap"">
                    <figure>
                        <img src=""images/portfolio/web3.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 1720, "\"", 1726, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <a href=""images/portfolio/web3.jpg"" class=""link-preview"" data-lightbox=""portfolio"" data-title=""Web 3"" title=""Preview""><i class=""ion ion-eye""></i></a>
                        <a href=""#"" class=""link-details"" title=""More Details""><i class=""ion ion-android-open""></i></a>
                    </figure>

                    <div class=""portfolio-info"">
                        <h4><a href=""#"">Web 3</a></h4>
                        <p>Web</p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 col-md-6 portfolio-item filter-app wow fadeInUp"" data-wow-delay=""0.2s"">
                <div class=""portfolio-wrap"">
                    <figure>
                        <img src=""images/portfolio/app2.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 2534, "\"", 2540, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <a href=""images/portfolio/app2.jpg"" class=""link-preview"" data-lightbox=""portfolio"" data-title=""App 2"" title=""Preview""><i class=""ion ion-eye""></i></a>
                        <a href=""#"" class=""link-details"" title=""More Details""><i class=""ion ion-android-open""></i></a>
                    </figure>

                    <div class=""portfolio-info"">
                        <h4><a href=""#"">App 2</a></h4>
                        <p>App</p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 col-md-6 portfolio-item filter-card wow fadeInUp"">
                <div class=""portfolio-wrap"">
                    <figure>
                        <img src=""images/portfolio/card2.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 3328, "\"", 3334, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <a href=""images/portfolio/card2.jpg"" class=""link-preview"" data-lightbox=""portfolio"" data-title=""Card 2"" title=""Preview""><i class=""ion ion-eye""></i></a>
                        <a href=""#"" class=""link-details"" title=""More Details""><i class=""ion ion-android-open""></i></a>
                    </figure>

                    <div class=""portfolio-info"">
                        <h4><a href=""#"">Card 2</a></h4>
                        <p>Card</p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 col-md-6 portfolio-item filter-web wow fadeInUp"" data-wow-delay=""0.1s"">
                <div class=""portfolio-wrap"">
                    <figure>
                        <img src=""images/portfolio/web2.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4146, "\"", 4152, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <a href=""images/portfolio/web2.jpg"" class=""link-preview"" data-lightbox=""portfolio"" data-title=""Web 2"" title=""Preview""><i class=""ion ion-eye""></i></a>
                        <a href=""#"" class=""link-details"" title=""More Details""><i class=""ion ion-android-open""></i></a>
                    </figure>

                    <div class=""portfolio-info"">
                        <h4><a href=""#"">Web 2</a></h4>
                        <p>Web</p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 col-md-6 portfolio-item filter-app wow fadeInUp"" data-wow-delay=""0.2s"">
                <div class=""portfolio-wrap"">
                    <figure>
                        <img src=""images/portfolio/app3.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4960, "\"", 4966, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <a href=""images/portfolio/app3.jpg"" class=""link-preview"" data-lightbox=""portfolio"" data-title=""App 3"" title=""Preview""><i class=""ion ion-eye""></i></a>
                        <a href=""#"" class=""link-details"" title=""More Details""><i class=""ion ion-android-open""></i></a>
                    </figure>

                    <div class=""portfolio-info"">
                        <h4><a href=""#"">App 3</a></h4>
                        <p>App</p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 col-md-6 portfolio-item filter-card wow fadeInUp"">
                <div class=""portfolio-wrap"">
                    <figure>
                        <img src=""images/portfolio/card1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 5754, "\"", 5760, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <a href=""images/portfolio/card1.jpg"" class=""link-preview"" data-lightbox=""portfolio"" data-title=""Card 1"" title=""Preview""><i class=""ion ion-eye""></i></a>
                        <a href=""#"" class=""link-details"" title=""More Details""><i class=""ion ion-android-open""></i></a>
                    </figure>

                    <div class=""portfolio-info"">
                        <h4><a href=""#"">Card 1</a></h4>
                        <p>Card</p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 col-md-6 portfolio-item filter-card wow fadeInUp"" data-wow-delay=""0.1s"">
                <div class=""portfolio-wrap"">
                    <figure>
                        <img src=""images/portfolio/card3.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 6574, "\"", 6580, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <a href=""images/portfolio/card3.jpg"" class=""link-preview"" data-lightbox=""portfolio"" data-title=""Card 3"" title=""Preview""><i class=""ion ion-eye""></i></a>
                        <a href=""#"" class=""link-details"" title=""More Details""><i class=""ion ion-android-open""></i></a>
                    </figure>

                    <div class=""portfolio-info"">
                        <h4><a href=""#"">Card 3</a></h4>
                        <p>Card</p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 col-md-6 portfolio-item filter-web wow fadeInUp"" data-wow-delay=""0.2s"">
                <div class=""portfolio-wrap"">
                    <figure>
                        <img src=""images/portfolio/web1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 7392, "\"", 7398, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <a href=""images/portfolio/web1.jpg"" class=""link-preview"" data-lightbox=""portfolio"" data-title=""Web 1"" title=""Preview""><i class=""ion ion-eye""></i></a>
                        <a href=""#"" class=""link-details"" title=""More Details""><i class=""ion ion-android-open""></i></a>
                    </figure>

                    <div class=""portfolio-info"">
                        <h4><a href=""#"">Web 1</a></h4>
                        <p>Web</p>
                    </div>
                </div>
            </div>

        </div>

    </div>
</section><!-- #portfolio -->");
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
