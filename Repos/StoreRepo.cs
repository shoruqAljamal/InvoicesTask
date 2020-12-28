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
    public class StoreRepo : IStoreRepo
    {

        private readonly InvoiceContext _InvoiceContext;

        public StoreRepo(InvoiceContext InvoiceContext)
        {
            _InvoiceContext = InvoiceContext;
        }
        public async Task<List<Store>> GetAllStores()
        {
            var stores = await _InvoiceContext.Stores.ToListAsync();
            return stores;
        }
    }
}
