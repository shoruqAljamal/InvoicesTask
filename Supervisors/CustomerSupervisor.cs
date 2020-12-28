using InvoicesTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Supervisors
{
    public partial class Supervisor
    {
        public async Task<List<CustomerModel>> GetAllCustomers()
        {

            var customers = await _ICustomerRepo.GetAllCustomers();
            return _mapper.Map<List<CustomerModel>>(customers);
        }

    }
}
