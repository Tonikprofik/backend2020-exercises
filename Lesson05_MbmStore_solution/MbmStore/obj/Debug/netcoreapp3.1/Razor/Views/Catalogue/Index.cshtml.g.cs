#pragma checksum "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6138102643455f0571feb027e3cc3cd72228f128"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogue_Index), @"mvc.1.0.view", @"/Views/Catalogue/Index.cshtml")]
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
#line 1 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
using MbmStore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6138102643455f0571feb027e3cc3cd72228f128", @"/Views/Catalogue/Index.cshtml")]
    public class Views_Catalogue_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6138102643455f0571feb027e3cc3cd72228f1285191", async() => {
                WriteLiteral("\r\n    <title>MbmStore Catalogue</title>\r\n");
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6138102643455f0571feb027e3cc3cd72228f1286210", async() => {
                WriteLiteral("\r\n    <h2>The Books</h2>\r\n    <table>\r\n        \r\n\r\n");
#nullable restore
#line 23 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
         foreach (Book book in Model.OfType<Book>().ToList())
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\r\n            <td valign=\"top\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6138102643455f0571feb027e3cc3cd72228f1286892", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 469, "~/images/", 469, 9, true);
#nullable restore
#line 26 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 478, book.ImageUrl, 478, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 499, book.Title, 499, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </td>\r\n            <td valign=\"top\" style=\"250px\">\r\n                <div>\r\n                    <strong>Title:</strong> ");
#nullable restore
#line 30 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                       Write(book.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                    <strong>Author:</strong> ");
#nullable restore
#line 31 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                        Write(book.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                    <strong>Price:</strong> ");
#nullable restore
#line 32 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                       Write(book.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                    <strong>Publisher:</strong> ");
#nullable restore
#line 33 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                           Write(book.Publisher);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 33 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                                            Write(book.Published);

#line default
#line hidden
#nullable disable
                WriteLiteral(")<br />\r\n                    <strong>ISBN:</strong> ");
#nullable restore
#line 34 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                      Write(book.ISBN);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br /> <br />\r\n");
                WriteLiteral("                </div>\r\n            </td>\r\n            <td style=\"vertical-align:bottom; padding-left:50px\">\r\n                <div>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6138102643455f0571feb027e3cc3cd72228f12811463", async() => {
                    WriteLiteral("\r\n                        <input type=\"hidden\" name=\"ProductID\"");
                    BeginWriteAttribute("value", " value=\"", 1334, "\"", 1357, 1);
#nullable restore
#line 41 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 1342, book.ProductID, 1342, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"returnUrl\"");
                    BeginWriteAttribute("value", " value=\"", 1424, "\"", 1479, 1);
#nullable restore
#line 42 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 1432, ViewContext.HttpContext.Request.PathandQuery(), 1432, 47, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                        <span class=""card-text p-1"">
                            <button type=""submit"" class=""btn btn-success btn-sm pull-right"" style=""float:right"">
                                Add to Cart
                            </button>
                        </span>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 40 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 1195, book.ProductID, 1195, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 52 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n\r\n    <br />\r\n    <br />\r\n\r\n    <h2>The Music CDs</h2>\r\n    <table>\r\n");
#nullable restore
#line 60 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
         foreach (MusicCD cd in Model.OfType<MusicCD>().ToList())
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td valign=\"top\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6138102643455f0571feb027e3cc3cd72228f12816059", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2112, "~/images/", 2112, 9, true);
#nullable restore
#line 64 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 2121, cd.ImageUrl, 2121, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 64 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 2140, cd.Title, 2140, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </td>\r\n                <td valign=\"top\" style=\"250px\">\r\n                    <div>\r\n                        <strong>Album:</strong> ");
#nullable restore
#line 68 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                           Write(cd.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        <strong>Artist:</strong> ");
#nullable restore
#line 69 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                            Write(cd.Artist);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        <strong>Price:</strong> ");
#nullable restore
#line 70 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                           Write(cd.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        <strong>Publisher:</strong> ");
#nullable restore
#line 71 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                               Write(cd.Label);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 71 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                                          Write(cd.Released);

#line default
#line hidden
#nullable disable
                WriteLiteral(")<br /> <br />\r\n\r\n                    </div>\r\n                    <div>\r\n                        <strong>Tracks:</strong>\r\n\r\n                        <ol>\r\n\r\n");
#nullable restore
#line 79 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                             foreach (Track track in @cd.Tracks)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li>");
#nullable restore
#line 81 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                               Write(track.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 81 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                             Write(track.Composer);

#line default
#line hidden
#nullable disable
                WriteLiteral(") ");
#nullable restore
#line 81 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                                              Write(track.Length.Minutes);

#line default
#line hidden
#nullable disable
                WriteLiteral(":");
#nullable restore
#line 81 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                                                                    Write(track.Length.Seconds);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </li>\r\n");
#nullable restore
#line 82 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </ol>\r\n                        <p><strong>Total playing time</strong>: ");
#nullable restore
#line 85 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                                           Write(cd.GetPlayingTime().Minutes);

#line default
#line hidden
#nullable disable
                WriteLiteral(":");
#nullable restore
#line 85 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                                                                        Write(cd.GetPlayingTime().Seconds);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </div>\r\n                </td>\r\n                <td style=\"vertical-align:bottom; padding-left:50px\">\r\n                    <div>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6138102643455f0571feb027e3cc3cd72228f12823192", async() => {
                    WriteLiteral("\r\n                            <input type=\"hidden\" name=\"ProductID\"");
                    BeginWriteAttribute("value", " value=\"", 3433, "\"", 3454, 1);
#nullable restore
#line 91 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 3441, cd.ProductID, 3441, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"returnUrl\"");
                    BeginWriteAttribute("value", " value=\"", 3525, "\"", 3580, 1);
#nullable restore
#line 92 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 3533, ViewContext.HttpContext.Request.PathandQuery(), 3533, 47, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                            <span class=""card-text p-1"">
                                <button type=""submit"" class=""btn btn-success btn-sm pull-right"" style=""float:right"">
                                    Add to Cart
                                </button>
                            </span>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 90 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 3292, cd.ProductID, 3292, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 102 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n\r\n    <br />\r\n    <br />\r\n\r\n    <h2>The Movies</h2>\r\n    <table>\r\n");
#nullable restore
#line 110 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
         foreach (Movie movie in Model.OfType<Movie>().ToList())
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td valign=\"top\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6138102643455f0571feb027e3cc3cd72228f12827826", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4245, "~/images/", 4245, 9, true);
#nullable restore
#line 114 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 4254, movie.ImageUrl, 4254, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 114 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 4276, movie.Title, 4276, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </td>\r\n                <td valign=\"top\" style=\"250px\">\r\n                    <div>\r\n                        <strong>Title:</strong> ");
#nullable restore
#line 118 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                           Write(movie.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        <strong>Director:</strong> ");
#nullable restore
#line 119 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                              Write(movie.Director);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>\r\n                        <strong>Price:</strong> ");
#nullable restore
#line 120 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                           Write(String.Format("{0:0.00}", movie.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 4677, "\"", 4706, 2);
                WriteAttributeValue("", 4683, "/Images/", 4683, 8, true);
#nullable restore
#line 121 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 4691, movie.ImageUrl, 4691, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 4707, "\"", 4725, 1);
#nullable restore
#line 121 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 4713, movie.Title, 4713, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n                <td style=\"vertical-align:bottom; padding-left:50px\">\r\n                    <div>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6138102643455f0571feb027e3cc3cd72228f12832309", async() => {
                    WriteLiteral("\r\n                            <input type=\"hidden\" name=\"ProductID\"");
                    BeginWriteAttribute("value", " value=\"", 5035, "\"", 5059, 1);
#nullable restore
#line 126 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 5043, movie.ProductID, 5043, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"returnUrl\"");
                    BeginWriteAttribute("value", " value=\"", 5130, "\"", 5185, 1);
#nullable restore
#line 127 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 5138, ViewContext.HttpContext.Request.PathandQuery(), 5138, 47, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                            <span class=""card-text p-1"">
                                <button type=""submit"" class=""btn btn-success btn-sm pull-right"" style=""float:right"">
                                    Add to Cart
                                </button>
                            </span>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 125 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
AddHtmlAttributeValue("", 4891, movie.ProductID, 4891, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 137 "C:\Treihard\VS C#\Lesson05MbmStore\backend2020-exercises\Lesson05_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
