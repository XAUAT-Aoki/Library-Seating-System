#pragma checksum "D:\Program Code\LSS\Library-Seating-System\Library-Seating-System\LSS\Views\Administrator\AddFloor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93e3f0e63ae01b76022766ada090e5638e73a181"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_AddFloor), @"mvc.1.0.razor-page", @"/Views/Administrator/AddFloor.cshtml")]
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
#line 1 "D:\Program Code\LSS\Library-Seating-System\Library-Seating-System\LSS\Views\_ViewImports.cshtml"
using LSS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Program Code\LSS\Library-Seating-System\Library-Seating-System\LSS\Views\_ViewImports.cshtml"
using LSS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Program Code\LSS\Library-Seating-System\Library-Seating-System\LSS\Views\Administrator\AddFloor.cshtml"
using LSS.Infrastructure.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93e3f0e63ae01b76022766ada090e5638e73a181", @"/Views/Administrator/AddFloor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f7e316f3020425f5e88aba2b45efe16aee2f34", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_AddFloor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/numscroller-1.0.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.flexisel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/SmoothScroll.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/move-top.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/easing.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/checkStudentOrder.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Program Code\LSS\Library-Seating-System\Library-Seating-System\LSS\Views\Administrator\AddFloor.cshtml"
  
    Layout = "_IndexLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"" style=""opacity: 0.6;"">
    <div class=""services-breadcrumb"">
        <div class=""inner_breadcrumb"">
            <ul class=""short_ls"">
                <li>
                    <a href=""index.html"">首页</a>
                    <span>| |</span>
                </li>
                <li>Gallery</li>
            </ul>
        </div>
    </div>
</div>

<div class=""container"" style=""margin-top: 15px;"">
    <div class=""row"">
        <div class=""col-md-2"">
            <div class=""panel panel-success leftSidebar"" id=""leftSidebar"">
                <div class=""panel-heading"">
                    <h3 class=""panel-title"">快捷菜单</h3>
                </div>
                <div class=""panel-body"">
                    <a");
            BeginWriteAttribute("id", " id=\"", 868, "\"", 873, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 874, "\"", 881, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item\">返回首页</a>\r\n                    <a");
            BeginWriteAttribute("id", " id=\"", 939, "\"", 944, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 945, "\"", 952, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item\">查看学生信息</a>\r\n                    <a");
            BeginWriteAttribute("id", " id=\"", 1012, "\"", 1017, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1018, "\"", 1025, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item\">密码修改</a>\r\n                    <a");
            BeginWriteAttribute("id", " id=\"", 1083, "\"", 1088, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1089, "\"", 1096, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item\">查询预订信息</a>\r\n                    <a");
            BeginWriteAttribute("id", " id=\"", 1156, "\"", 1161, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1162, "\"", 1169, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item\">查询座位</a>\r\n                    <a id=\"top\"");
            BeginWriteAttribute("href", " href=\"", 1236, "\"", 1243, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""list-group-item"">回到顶部</a>
                </div>
            </div>
        </div>
        <div class=""col-md-10"">
            <div class=""container"" id=""studentInformation"">
                <div class=""page-header"" style=""margin-top: 15px;"">
                    <h1><small>修改图书馆楼层</small></h1>
                </div>
                <div class=""libraryList"" data-example-id=""hoverable-table"">
                    <table class=""table table-hover table-bordered"">
                        <thead>
                            <tr>
                                <th>编号</th>
                                <th>图书馆名</th>
                                <th>起始楼层</th>
                                <th>结束楼层</th>
                                <th>操作</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 58 "D:\Program Code\LSS\Library-Seating-System\Library-Seating-System\LSS\Views\Administrator\AddFloor.cshtml"
                             for (var i = 0; i < Model.Count(); i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th>");
#nullable restore
#line 61 "D:\Program Code\LSS\Library-Seating-System\Library-Seating-System\LSS\Views\Administrator\AddFloor.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 62 "D:\Program Code\LSS\Library-Seating-System\Library-Seating-System\LSS\Views\Administrator\AddFloor.cshtml"
                                   Write(Model[i].libraryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 63 "D:\Program Code\LSS\Library-Seating-System\Library-Seating-System\LSS\Views\Administrator\AddFloor.cshtml"
                                   Write(Model[i].startFloor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 楼</td>\r\n                                    <td>");
#nullable restore
#line 64 "D:\Program Code\LSS\Library-Seating-System\Library-Seating-System\LSS\Views\Administrator\AddFloor.cshtml"
                                   Write(Model[i].endFloor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 楼</td>\r\n                                    <td>\r\n                                        <button class=\"modify btn btn-success btn-sm\"");
            BeginWriteAttribute("onclick", "\r\n                                                onclick=\"", 2649, "\"", 2730, 3);
            WriteAttributeValue("", 2708, "modifyBtn(", 2708, 10, true);
#nullable restore
#line 67 "D:\Program Code\LSS\Library-Seating-System\Library-Seating-System\LSS\Views\Administrator\AddFloor.cshtml"
WriteAttributeValue("", 2718, i+1, 2718, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2724, ",this)", 2724, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            修改\r\n                                        </button>\r\n                                        <button class=\"delete btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", "\r\n                                                onclick=\"", 2917, "\"", 2998, 3);
            WriteAttributeValue("", 2976, "deleteBtn(", 2976, 10, true);
#nullable restore
#line 71 "D:\Program Code\LSS\Library-Seating-System\Library-Seating-System\LSS\Views\Administrator\AddFloor.cshtml"
WriteAttributeValue("", 2986, i+1, 2986, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2992, ",this)", 2992, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            删除\r\n                                        </button>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 76 "D:\Program Code\LSS\Library-Seating-System\Library-Seating-System\LSS\Views\Administrator\AddFloor.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Modal -->
<div class=""modal fade"" id=""ModifyModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"" id=""modifyModalTitle""></h4>
            </div>
            <div class=""modal-body"">
                <div class=""panel panel-info"">
                    <div class=""input-group"">
                        <input type=""number"" class=""form-control"" id=""modifyStartFloor"">
                        <span class=""input-group-addon"" id=""floorAddon"">楼</span>
                    </div>
                    <div class=""i");
            WriteLiteral(@"nput-group"">
                        <input type=""number"" class=""form-control"" id=""modifyEndFloor"">
                        <span class=""input-group-addon"" id=""floorAddon"">楼</span>
                    </div>
                </div>
            </div>

        </div>
        <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">取消</button>
            <button type=""button"" class=""btn btn-primary"" id=""floorModifyButton"">确定</button>
        </div>
    </div>
</div>
<!-- Modal -->
<div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"" id=""deleteModalTitle""></h4>");
            WriteLiteral(@"
            </div>
            <div class=""modal-body"">
                <p>确认删除图书馆</p><span id=""deleteLibraryName""></span><span>吗？</span>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">关闭</button>
                <button type=""button"" class=""btn btn-danger"">确认删除</button>
            </div>
        </div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e3f0e63ae01b76022766ada090e5638e73a18115796", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e3f0e63ae01b76022766ada090e5638e73a18116836", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e3f0e63ae01b76022766ada090e5638e73a18117876", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e3f0e63ae01b76022766ada090e5638e73a18118916", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e3f0e63ae01b76022766ada090e5638e73a18119956", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e3f0e63ae01b76022766ada090e5638e73a18120996", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e3f0e63ae01b76022766ada090e5638e73a18122036", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    var libraryName;
    var startFloor;
    var endFloor;

    function modifyBtn(id, obj) { //设置模态框中的数字   还需完成读输入框中数字格式的验证
        libraryName = $(obj).parent().parent(""tr"").children('td').eq(0).html();
        startFloor = parseInt($(obj).parent().parent(""tr"").children('td').eq(1).html());
        endFloor = parseInt($(obj).parent().parent(""tr"").children('td').eq(2).html());
        $(""#modifyModalTitle"").text(libraryName);
        $(""#modifyStartFloor"").attr({
            ""value"": startFloor
        });
        $(""#modifyEndFloor"").val(endFloor);
        $(""#ModifyModal"").modal(""show"");
        //将数据发送给后端，后端完成修改后返回数据

        //提示修改后状态
    }
    $(""#floorModifyButton"").click(function () {
        sendData();
    });



    function sendData() {
        $.ajax({
            type: 'post',
            url: '/Administrator/AddFloor',
            data: { ""libraryname"": libraryName, ""startfloor"": startFloor, ""endfloor"": endFloor },
            success: function (data) {");
            WriteLiteral(@"
                alert(data);
            },
            error: function (data) {
                alert(""修改失败"");
            }
        });
    }


    function deleteBtn(id, obj) {
        libraryName = $(obj).parent().parent(""tr"").children('td').eq(0).html();
        var str = ""删除图书馆"" + libraryName;
        $(""#deleteModalTitle"").text(str);
        $(""#deleteLibraryName"").text(libraryName);
        $(""#deleteModal"").modal(""show"");

        //传输id到后端，并输出后端返回的数据
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LibraryToShow>> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<List<LibraryToShow>> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<List<LibraryToShow>>)PageContext?.ViewData;
        public List<LibraryToShow> Model => ViewData.Model;
    }
}
#pragma warning restore 1591
