#pragma checksum "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\Components\AddAnimalCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e10e1d7f6b9e13ef1fd9dae4f5a3ec641ee99218"
// <auto-generated/>
#pragma warning disable 1591
namespace Cornelis.Examples.Blazor.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Cornelis.Examples.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Cornelis.Examples.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Cornelis.Examples.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Blazorise.Sidebar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Cornelis.Examples.Models.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Cornelis.Examples.Blazor.Components;

#line default
#line hidden
#nullable disable
    public partial class AddAnimalCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Card>(0);
            __builder.AddAttribute(1, "Class", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\Components\AddAnimalCard.razor"
              Class

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.CardBody>(3);
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.Field>(5);
                    __builder3.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.FieldLabel>(7);
                        __builder4.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(9, "Rfid:");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(10, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.FieldBody>(11);
                        __builder4.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.TextEdit>(13);
                            __builder5.AddAttribute(14, "Placeholder", "Rfid...");
                            __builder5.AddAttribute(15, "text", 
#nullable restore
#line 8 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\Components\AddAnimalCard.razor"
                                       Animal.Rfid

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddAttribute(16, "textChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Animal.Rfid = __value, Animal.Rfid));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\r\n\r\n        ");
                    __builder3.OpenComponent<Blazorise.Field>(18);
                    __builder3.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.FieldLabel>(20);
                        __builder4.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(22, "Kill Date:");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(23, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.FieldBody>(24);
                        __builder4.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.Cornelis.Examples.Blazor.Components.AddAnimalCard.TypeInference.CreateDateEdit_0(__builder5, 26, 27, 
#nullable restore
#line 15 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\Components\AddAnimalCard.razor"
                                       Animal.KillDate

#line default
#line hidden
#nullable disable
                            , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Animal.KillDate = __value, Animal.KillDate)), 29, () => Animal.KillDate);
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n\r\n        ");
                    __builder3.OpenComponent<Blazorise.Field>(31);
                    __builder3.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.FieldLabel>(33);
                        __builder4.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(35, "Body Number:");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(36, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.FieldBody>(37);
                        __builder4.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.Cornelis.Examples.Blazor.Components.AddAnimalCard.TypeInference.CreateNumericEdit_1(__builder5, 39, 40, 
#nullable restore
#line 22 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\Components\AddAnimalCard.razor"
                                           Animal.BodyNumber

#line default
#line hidden
#nullable disable
                            , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Animal.BodyNumber = __value, Animal.BodyNumber)), 42, () => Animal.BodyNumber);
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n\r\n        ");
                    __builder3.OpenComponent<Blazorise.Field>(44);
                    __builder3.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.FieldLabel>(46);
                        __builder4.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(48, "Ossification:");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(49, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.FieldBody>(50);
                        __builder4.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.Cornelis.Examples.Blazor.Components.AddAnimalCard.TypeInference.CreateNumericEdit_2(__builder5, 52, 53, 
#nullable restore
#line 29 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\Components\AddAnimalCard.razor"
                                           Animal.Ossification

#line default
#line hidden
#nullable disable
                            , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Animal.Ossification = __value, Animal.Ossification)), 55, () => Animal.Ossification);
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\r\n\r\n        ");
                    __builder3.OpenComponent<Blazorise.Field>(57);
                    __builder3.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.FieldLabel>(59);
                        __builder4.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(61, "Hump:");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(62, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.FieldBody>(63);
                        __builder4.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.Cornelis.Examples.Blazor.Components.AddAnimalCard.TypeInference.CreateNumericEdit_3(__builder5, 65, 66, 
#nullable restore
#line 36 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\Components\AddAnimalCard.razor"
                                           Animal.HumpHeight

#line default
#line hidden
#nullable disable
                            , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Animal.HumpHeight = __value, Animal.HumpHeight)), 68, () => Animal.HumpHeight);
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.Button>(70);
                    __builder3.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\Components\AddAnimalCard.razor"
                          Add

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 39 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\Components\AddAnimalCard.razor"
                                      Color.Dark

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(74, "Insert or Update");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.Button>(76);
                    __builder3.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\Components\AddAnimalCard.razor"
                          Search

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(78, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 40 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\Components\AddAnimalCard.razor"
                                         Color.Dark

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(80, "Search On RFID");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\Components\AddAnimalCard.razor"
       
    [Parameter]
    public string Class { get; set; }

    Animal Animal { get; set; } = new Animal();

    async void Add()
    {
        if (string.IsNullOrWhiteSpace(Animal.Rfid))
        {
            return;
        }

        var success = await AnimalManagentService.UpdateOrInsertAsync(Animal);

        if (success)
        {
            Animal = new Animal();
        }

        StateHasChanged();
    }

    async void Search()
    {
        if (string.IsNullOrWhiteSpace(Animal.Rfid))
        {
            return;
        }

        Animal = await AnimalManagentService.SearchAnimalAsync(Animal.Rfid);

        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAnimalManagementService AnimalManagentService { get; set; }
    }
}
namespace __Blazor.Cornelis.Examples.Blazor.Components.AddAnimalCard
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDateEdit_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Blazorise.DateEdit<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Date", __arg0);
        __builder.AddAttribute(__seq1, "DateChanged", __arg1);
        __builder.AddAttribute(__seq2, "DateExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateNumericEdit_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Blazorise.NumericEdit<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateNumericEdit_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Blazorise.NumericEdit<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateNumericEdit_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Blazorise.NumericEdit<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591