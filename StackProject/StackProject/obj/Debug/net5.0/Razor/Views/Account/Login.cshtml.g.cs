#pragma checksum "C:\Users\Daffolap-1002\Desktop\net. files\StackProject\StackProject\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3330891a58606f0a4247981c10028d0b483725f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3330891a58606f0a4247981c10028d0b483725f", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3330891a58606f0a4247981c10028d0b483725f2750", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.8.1/css/all.css"">
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <style>

        * {
            list-style: none;
            text-decoration: none;
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: 'Open Sans', sans-serif;
        }

        body {
            background: #f5f6fa;
        }

        .wrapper .sidebar {
            background: rgb(5, 68, 104);
            position: fixed;
            top: 0;
            left: 0;
            width: 225px;
            height: 100%;
            padding: 20px 0;
            transition: all 0.5s ease;
        }

            .wrapper .sidebar .profile {
                margin-bottom: 30px;
                text-align: center;
            }


             ");
                WriteLiteral(@"   .wrapper .sidebar .profile h3 {
                    color: #ffffff;
                    margin: 10px 0 5px;
                }

                .wrapper .sidebar .profile p {
                    color: rgb(206, 240, 253);
                    font-size: 14px;
                }

            .wrapper .sidebar ul li a {
                display: block;
                padding: 13px 30px;
                border-bottom: 1px solid #10558d;
                color: rgb(241, 237, 237);
                font-size: 16px;
                position: relative;
            }

                .wrapper .sidebar ul li a .icon {
                    color: #dee4ec;
                    width: 30px;
                    display: inline-block;
                }

                .wrapper .sidebar ul li a:hover,
                .wrapper .sidebar ul li a.active {
                    color: #0c7db1;
                    background: white;
                    border-right: 2px solid rgb(5, 68, 104);
            ");
                WriteLiteral(@"    }

                    .wrapper .sidebar ul li a:hover .icon,
                    .wrapper .sidebar ul li a.active .icon {
                        color: #0c7db1;
                    }

                    .wrapper .sidebar ul li a:hover:before,
                    .wrapper .sidebar ul li a.active:before {
                        display: block;
                    }

        .wrapper .section {
            width: calc(100% - 225px);
            margin-left: 225px;
            transition: all 0.5s ease;
        }

            .wrapper .section .top_navbar {
                background: rgb(7, 105, 185);
                height: 50px;
                display: flex;
                align-items: center;
                padding: 0 30px;
            }

                .wrapper .section .top_navbar .hamburger a {
                    font-size: 28px;
                    color: #f4fbff;
                }

                    .wrapper .section .top_navbar .hamburger a:hover {
        ");
                WriteLiteral(@"                color: #a2ecff;
                    }

        body.active .wrapper .sidebar {
            left: -225px;
        }

        body.active .wrapper .section {
            margin-left: 0;
            width: 100%;
        }

        .qt {
            padding: 20px;
        }
        .col-md-4{
            padding:20px;
        }
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3330891a58606f0a4247981c10028d0b483725f7281", async() => {
                WriteLiteral(@"


    <div class=""wrapper"">
        <!--Top menu -->
        <div class=""sidebar"">
            <!--profile image & text-->
            <div class=""profile"">
                <h3>Ayush Gaur</h3>
                <p>Admin</p>
            </div>
            <!--menu item-->
            <ul>
                <li>
                    <a");
                BeginWriteAttribute("href", " href=\"", 3849, "\"", 3884, 1);
#nullable restore
#line 138 "C:\Users\Daffolap-1002\Desktop\net. files\StackProject\StackProject\Views\Account\Login.cshtml"
WriteAttributeValue("", 3856, Url.Action("Index","Roles"), 3856, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <span class=\"icon\"><i class=\"fas fa-desktop\"></i></span>\r\n                        <span class=\"item\">My Dashboard</span>\r\n                    </a>\r\n                </li>\r\n                <li>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 4127, "\"", 4166, 1);
#nullable restore
#line 144 "C:\Users\Daffolap-1002\Desktop\net. files\StackProject\StackProject\Views\Account\Login.cshtml"
WriteAttributeValue("", 4134, Url.Action("Index","Questions"), 4134, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <span class=\"icon\"><i class=\"fas fa-desktop\"></i></span>\r\n                        <span class=\"item\">Questions</span>\r\n                    </a>\r\n                </li>\r\n                <li>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 4406, "\"", 4446, 1);
#nullable restore
#line 150 "C:\Users\Daffolap-1002\Desktop\net. files\StackProject\StackProject\Views\Account\Login.cshtml"
WriteAttributeValue("", 4413, Url.Action("Register","Account"), 4413, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <span class=""icon""><i class=""fas fa-desktop""></i></span>
                        <span class=""item"">Register</span>
                    </a>
                </li>
            </ul>
        </div>
        <div class=""section"">
            <div class=""top_navbar"">
                <div class=""hamburger"">
                    <a href=""#"">
                        <i class=""fas fa-bars""></i>
                    </a>
                </div>
            </div>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <form asp-action=""Login"" method=""post"">

                            <div class=""form-group"">
                                <label class=""control-label"">Email:</label>
                                <input type=""email"" class=""form-control"" id=""Email"" name=""Email"" placeholder=""Enter you Email"" />
                                <span validation-for=""Email"" class=""text-danger""></");
                WriteLiteral(@"span>
                            </div>
                            <div class=""form-group"">
                                <label class=""control-label"">Password:</label>
                                <input type=""password"" class=""form-control"" id=""Password"" name=""Password"" placeholder=""Enter you Password"" />
                                <span validation-for=""Password"" class=""text-danger""></span>
                            </div>
                            <div class=""form-group"">
                                <input type=""submit"" value=""Submit"" class=""btn btn-primary"" />
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>


    </div>
    <script>
        var hamburger = document.querySelector("".hamburger"");
        hamburger.addEventListener(""click"", function () {
            document.querySelector(""body"").classList.toggle(""active"");
        })
    </script>
");
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
            WriteLiteral("\r\n</html>");
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
