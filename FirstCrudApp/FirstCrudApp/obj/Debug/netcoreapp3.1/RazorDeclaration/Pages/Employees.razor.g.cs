// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FirstCrudApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Documents\GitHub\dotnet_core\FirstCrudApp\FirstCrudApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\dotnet_core\FirstCrudApp\FirstCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Documents\GitHub\dotnet_core\FirstCrudApp\FirstCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Documents\GitHub\dotnet_core\FirstCrudApp\FirstCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Documents\GitHub\dotnet_core\FirstCrudApp\FirstCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Documents\GitHub\dotnet_core\FirstCrudApp\FirstCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Documents\GitHub\dotnet_core\FirstCrudApp\FirstCrudApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Documents\GitHub\dotnet_core\FirstCrudApp\FirstCrudApp\_Imports.razor"
using FirstCrudApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Documents\GitHub\dotnet_core\FirstCrudApp\FirstCrudApp\_Imports.razor"
using FirstCrudApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employees")]
    public partial class Employees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\User\Documents\GitHub\dotnet_core\FirstCrudApp\FirstCrudApp\Pages\Employees.razor"
       
    private List<FirstCrudApp.Data.Employee> employees;

    protected override void OnInitialized()
    {
        employees = EmployeeService.GetEmployees();
    }

    private void OnDelete(Guid id)
    {
        EmployeeService.DeleteEmployee(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FirstCrudApp.Data.IEmployeeService EmployeeService { get; set; }
    }
}
#pragma warning restore 1591
