using ComponentArchitecture01.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComponentArchitecture01.Shared.Abstract
{
    public interface ICustomerService
    {
        List<CustomerViewModel> GetAll();
        bool Remove(CustomerViewModel item);
    }
}
