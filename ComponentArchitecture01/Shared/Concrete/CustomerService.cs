using ComponentArchitecture01.Shared.Abstract;
using ComponentArchitecture01.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComponentArchitecture01.Shared.Concrete
{
    public class CustomerService : ICustomerService
    {

        private List<CustomerViewModel> CustomerServiceList { get; set; }

        public CustomerService()
        {
            CustomerServiceList = new List<CustomerViewModel>();
            CustomerServiceList.Add(new CustomerViewModel { Id = 1, FullName = "Ünal ün" });
            CustomerServiceList.Add(new CustomerViewModel { Id = 2, FullName = "Hüseyin Tuncay" });
            CustomerServiceList.Add(new CustomerViewModel { Id = 3, FullName = "Mine Kara" });
        }

        public List<CustomerViewModel> GetAll()
        {
            return CustomerServiceList;
        }

        public bool Remove(CustomerViewModel item)
        {
            bool isBool = false;

            if (item != null)
            {
                CustomerServiceList.Remove(item);
                isBool = true;
            }

            return isBool;
        }
    }
}
