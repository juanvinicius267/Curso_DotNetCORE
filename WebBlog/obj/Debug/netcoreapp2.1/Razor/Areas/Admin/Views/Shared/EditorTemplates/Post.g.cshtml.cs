#pragma checksum "C:\Users\aspnet8475\source\repos\WebBlog\WebBlog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9743a078ada3df1910c9f5c75e10bbf038619332"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_EditorTemplates_Post), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/EditorTemplates/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/EditorTemplates/Post.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_EditorTemplates_Post))]
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
#line 3 "C:\Users\aspnet8475\source\repos\WebBlog\WebBlog\Areas\Admin\Views\_ViewImports.cshtml"
using WebBlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9743a078ada3df1910c9f5c75e10bbf038619332", @"/Areas/Admin/Views/Shared/EditorTemplates/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e4340ab5a12976c71f40189a1920cb25377ea9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_EditorTemplates_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBlog.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\aspnet8475\source\repos\WebBlog\WebBlog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
  
    ViewData["Title"] = "Post";

#line default
#line hidden
            BeginContext(70, 15, true);
            WriteLiteral("<h2>Post</h2>\r\n");
            EndContext();
            BeginContext(86, 27, false);
#line 7 "C:\Users\aspnet8475\source\repos\WebBlog\WebBlog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.LabelFor(p=> p.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(113, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(116, 61, false);
#line 8 "C:\Users\aspnet8475\source\repos\WebBlog\WebBlog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.TextBoxFor(p=> p.Titulo, new {@class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(177, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(180, 40, false);
#line 9 "C:\Users\aspnet8475\source\repos\WebBlog\WebBlog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.ValidationMessageFor(p => p.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(220, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(225, 28, false);
#line 11 "C:\Users\aspnet8475\source\repos\WebBlog\WebBlog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.LabelFor(p => p.Resumo));

#line default
#line hidden
            EndContext();
            BeginContext(253, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(256, 74, false);
#line 12 "C:\Users\aspnet8475\source\repos\WebBlog\WebBlog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.TextBoxFor(p => p.Resumo, new { @class = "form-control" , rows = 6 }));

#line default
#line hidden
            EndContext();
            BeginContext(330, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(333, 40, false);
#line 13 "C:\Users\aspnet8475\source\repos\WebBlog\WebBlog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.ValidationMessageFor(p => p.Resumo));

#line default
#line hidden
            EndContext();
            BeginContext(373, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(378, 31, false);
#line 15 "C:\Users\aspnet8475\source\repos\WebBlog\WebBlog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.LabelFor(p => p.Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(409, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(412, 66, false);
#line 16 "C:\Users\aspnet8475\source\repos\WebBlog\WebBlog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.TextBoxFor(p => p.Categoria, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(478, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(481, 43, false);
#line 17 "C:\Users\aspnet8475\source\repos\WebBlog\WebBlog\Areas\Admin\Views\Shared\EditorTemplates\Post.cshtml"
Write(Html.ValidationMessageFor(p => p.Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(524, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBlog.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
