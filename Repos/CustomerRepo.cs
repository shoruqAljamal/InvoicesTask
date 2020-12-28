using InvoicesTask.Context;
using InvoicesTask.Entities;
using InvoicesTask.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Repos
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly InvoiceContext _InvoiceContext;

        public CustomerRepo(InvoiceContext InvoiceContext)
        {
            _InvoiceContext = InvoiceContext;
        }
        public async Task<List<Customer>> GetAllCustomers()
        {
            var customers = await _InvoiceContext.Customers.ToListAsync();
            return customers;
        }
    }
}
