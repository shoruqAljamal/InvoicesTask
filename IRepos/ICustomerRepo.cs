using InvoicesTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.IRepos
{
    public interface ICustomerRepo
    {
        Task<List<Customer>> GetAllCustomers();
    }
}
