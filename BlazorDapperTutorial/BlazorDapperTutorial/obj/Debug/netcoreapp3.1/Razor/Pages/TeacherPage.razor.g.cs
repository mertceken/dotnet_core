#pragma checksum "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\Pages\TeacherPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d39eaf6c3e17773e8521c3666f89b20f568eca49"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDapperTutorial.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\_Imports.razor"
using BlazorDapperTutorial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\_Imports.razor"
using BlazorDapperTutorial.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\Pages\TeacherPage.razor"
using BlazorDapperTutorial.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/teacher")]
    public partial class TeacherPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Teachers Page</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "DivbasicForm");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-4");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<label>Teacher Name</label>\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "placeholder", "Teacher Name");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\Pages\TeacherPage.razor"
                                                                  teacher.TeacherName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => teacher.TeacherName = __value, teacher.TeacherName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-md-4");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.AddMarkupContent(22, "<label>Branch</label>\r\n            ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "text");
            __builder.AddAttribute(25, "placeholder", "Branch");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\Pages\TeacherPage.razor"
                                                            teacher.Branch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => teacher.Branch = __value, teacher.Branch));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-md-4");
            __builder.AddMarkupContent(33, "\r\n            <label></label>\r\n            ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-success");
            __builder.AddAttribute(36, "style", "margin-top:30px;");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\Pages\TeacherPage.razor"
                                                                                Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(43, "table");
            __builder.AddAttribute(44, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.AddMarkupContent(46, "<thead>\r\n        <tr>\r\n            <th>Teacher ID</th>\r\n            <th>Teacher Name</th>\r\n            <th>Branch</th>\r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(47, "tbody");
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 36 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\Pages\TeacherPage.razor"
         foreach (var tea in teachers)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "            ");
            __builder.OpenElement(50, "tr");
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 39 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\Pages\TeacherPage.razor"
                     tea.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 40 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\Pages\TeacherPage.razor"
                     tea.TeacherName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 41 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\Pages\TeacherPage.razor"
                     tea.Branch

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "td");
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "class", "btn btn-primary");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\Pages\TeacherPage.razor"
                                                                e=> GetById(@tea.ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "style", "float:left");
            __builder.AddContent(67, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "class", "btn btn-primary");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\Pages\TeacherPage.razor"
                                                                e=> Delete(@tea)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "style", "float:left");
            __builder.AddContent(73, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
#nullable restore
#line 47 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\Pages\TeacherPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(77, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\User\Desktop\BlazorDapperTutorial\BlazorDapperTutorial\Pages\TeacherPage.razor"
       
    List<Teacher> teachers = new List<Teacher>();

    Teacher teacher = new Teacher();

    string Message = "";

    protected override async Task OnInitializedAsync()
    {
        GetTeachers();
    }

    private void GetTeachers()
    {
        teachers = teacherService.GetTeachers();
    }

    private void GetById(int id)
    {
        teacher = teacherService.GetById(id);
    }

    private void Save()
    {
        var teacherObj = new Teacher();
        teacherObj = teacherService.SaveOrUpdate(teacher);
        teacher = new Teacher();
        GetTeachers();
    }

    private void Delete(Teacher oTeacher)
    {
        Message = teacherService.Delete(oTeacher.ID);
        teachers.RemoveAll(x => x.ID == oTeacher.ID);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorDapperTutorial.IService.ITeacherService teacherService { get; set; }
    }
}
#pragma warning restore 1591