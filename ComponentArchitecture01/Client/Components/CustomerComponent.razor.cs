using ComponentArchitecture01.Shared.ViewModel;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace ComponentArchitecture01.Client.Components
{
    public partial class CustomerComponent
    {
        [Parameter] public List<CustomerViewModel> CustomerList { get; set; }
        [Parameter] public EventCallback<CustomerViewModel> Remove { get; set; }
    }
}



