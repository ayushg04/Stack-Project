#pragma checksum "C:\Users\Daffolap-1002\Desktop\net. files\StackProject\StackProject\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71da5b4f73119dd609e915249b25a8db368bd63c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\Daffolap-1002\Desktop\net. files\StackProject\StackProject\Views\Users\Index.cshtml"
using DataLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71da5b4f73119dd609e915249b25a8db368bd63c", @"/Views/Users/Index.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71da5b4f73119dd609e915249b25a8db368bd63c2927", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.8.1/css/all.css"">
    <meta charset=""UTF-8"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <script type=""text/javascript"" src=""http://cdnjs.cloudflare.com/ajax/libs/json2/20130526/json2.min.js""></script>
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
            padding:");
                WriteLiteral(@" 20px 0;
            transition: all 0.5s ease;
        }

            .wrapper .sidebar .profile {
                margin-bottom: 30px;
                text-align: center;
            }


                .wrapper .sidebar .profile h3 {
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

                .wrapper .sidebar ul li a");
                WriteLiteral(@":hover,
                .wrapper .sidebar ul li a.active {
                    color: #0c7db1;
                    background: white;
                    border-right: 2px solid rgb(5, 68, 104);
                }

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

                .wrapper .");
                WriteLiteral(@"section .top_navbar .hamburger a {
                    font-size: 28px;
                    color: #f4fbff;
                }

                    .wrapper .section .top_navbar .hamburger a:hover {
                        color: #a2ecff;
                    }

        body.active .wrapper .sidebar {
            left: -225px;
        }

        body.active .wrapper .section {
            margin-left: 0;
            width: 100%;
        }

        .col-md-6 {
            padding: 20px 20px 20px 20px;
        }

        .voter {
            position: absolute;
            font-size: x-large;
            margin-top: 20px;
        }

        .ans-desc {
            margin: 20px 20px 20px 40px;
        }

        .upper {
            background-color: khaki;
            color: saddlebrown;
        }

        .middle {
            color: darkgoldenrod;
            font-size: unset;
        }

        .lower {
            font-size: large;
        }

        button {
   ");
                WriteLiteral("         border: 0;\r\n            cursor: pointer;\r\n            font-size: 15px;\r\n            padding: 5px 10px;\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71da5b4f73119dd609e915249b25a8db368bd63c8299", async() => {
                WriteLiteral(@"

    <div class=""wrapper"">
        <!--Top menu -->
        <div class=""sidebar"">
            <!--profile image & text-->
            <div class=""profile"">
                <h3>Ayush Gaur</h3>
                <p>Index-Dash</p>
            </div>
            <!--menu item-->
            <ul>
                <li>
                    <a");
                BeginWriteAttribute("href", " href=\"", 4656, "\"", 4691, 1);
#nullable restore
#line 167 "C:\Users\Daffolap-1002\Desktop\net. files\StackProject\StackProject\Views\Users\Index.cshtml"
WriteAttributeValue("", 4663, Url.Action("Index","Roles"), 4663, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <span class=\"icon\"><i class=\"fas fa-desktop\"></i></span>\r\n                        <span class=\"item\">My Dashboard</span>\r\n                    </a>\r\n                </li>\r\n                <li>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 4934, "\"", 4972, 1);
#nullable restore
#line 173 "C:\Users\Daffolap-1002\Desktop\net. files\StackProject\StackProject\Views\Users\Index.cshtml"
WriteAttributeValue("", 4941, Url.Action("Logout","Account"), 4941, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <span class=\"icon\"><i class=\"fas fa-cog\"></i></span>\r\n                        <span class=\"item\">Logout</span>\r\n                    </a>\r\n                </li>\r\n                <li>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 5205, "\"", 5244, 1);
#nullable restore
#line 179 "C:\Users\Daffolap-1002\Desktop\net. files\StackProject\StackProject\Views\Users\Index.cshtml"
WriteAttributeValue("", 5212, Url.Action("Index","Questions"), 5212, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <span class=""icon""><i class=""fas fa-user-shield""></i></span>
                        <span class=""item"">Questions</span>
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
                    <div class=""upper col-md-6"">
                        <h2>How to create roles in ASP.NET Core and assign them to users?</h2>
                    </div>

                    <hr />

                    <div class=""middle col-md-6"">
                        <h5>I am using the ASP.NET Core default website template and have the authentication selected as ""Individual User Accounts"". How can I create roles and assign it to users");
                WriteLiteral(@" so that I can use the roles in a controller to filter access?</h5>
                    </div>

                    <hr />
                    <div class=""lower col-md-6"">

                        <div class=""voter"">
                            <button class=""posi"" id=""posi"" method=""post"" type=""button"" onclick=""plus()"" style=""font-size: 20px;"">+</button>

");
                WriteLiteral("                                <p id=\"voter\" class=\"votes\">\r\n");
                WriteLiteral("                                    0\r\n                                </p>\r\n");
                WriteLiteral(@"
                            <button class=""negi"" id=""negi"" method=""post"" type=""button"" onclick=""minus()"" style=""font-size: 20px;"">-</button>
                        </div>
                        <div class=""ans-desc"">
                            <p>
                                <br />
                                I have created an action in the Accounts controller that calls a function to create the roles and assign the Admin role to the default user. (You should probably remove the default user in production):
                                <br />
                                private async Task CreateRolesandUsers()<br />
                                {<br />
                                bool x = await _roleManager.RoleExistsAsync(""Admin"");<br />
                                if (!x)<br />
                                {<br />
                                // first we create Admin rool<br />
                                var role = new IdentityRole();<br />
           ");
                WriteLiteral(@"                     role.Name = ""Admin"";<br />
                                await _roleManager.CreateAsync(role);<br />
                                <br />
                                //Here we create a Admin super user who will maintain the website<br />

                                var user = new ApplicationUser();<br />
                                user.UserName = ""default"";<br />
                                user.Email = ""default@default.com"";<br />

                                string userPWD = ""somepassword"";<br />

                                IdentityResult chkUser = await _userManager.CreateAsync(user, userPWD);<br />

                                //Add default User to Role Admin<br />
                                if (chkUser.Succeeded)<br />
                                {<br />
                                var result1 = await _userManager.AddToRoleAsync(user, ""Admin"");<br />
                                }<br />
                             ");
                WriteLiteral(@"   }<br />

                                // creating Creating Manager role<br />
                                x = await _roleManager.RoleExistsAsync(""Manager"");<br />
                                if (!x)<br />
                                {<br />
                                var role = new IdentityRole();<br />
                                role.Name = ""Manager"";<br />
                                await _roleManager.CreateAsync(role);<br />
                                }<br />

                                // creating Creating Employee role<br />
                                x = await _roleManager.RoleExistsAsync(""Employee"");<br />
                                if (!x)<br />
                                {<br />
                                var role = new IdentityRole();<br />
                                role.Name = ""Employee"";<br />
                                await _roleManager.CreateAsync(role);<br />
                                }<br />
   ");
                WriteLiteral(@"                             }<br />
                                After you could create a controller to manage roles for the users.<br />
                            </p>

                            <hr />
                        </div>
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
        var voter = 0;

        function plus() {
            voter += 1;
            document.getElementById(""voter"").innerHTML = voter;

            submitBtn()
        }

        function minus() {
            voter -= 1;
            document.getElementById(""voter"").innerHTML = voter;
            submitBtn()
        }
        function submitBtn() {
            var data = $(""#posi"").val();
            console.log(data);

     ");
                WriteLiteral(@"       $.ajax({
                type: 'POST',
                url: '/Roles/Index',
                data: data,
                success: function (data) {

                    console.log(data);
                },
                error: function (error) {

                    console.log(error);
                }
            })
        }
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
