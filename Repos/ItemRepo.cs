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
    public class ItemRepo : IItemRepo
    {

        private readonly InvoiceContext _InvoiceContext;

        public ItemRepo(InvoiceContext InvoiceContext)
        {
            _InvoiceContext = InvoiceContext;
        }
        public async Task<List<Item>> GetAllItems()
        {
            var items = await _InvoiceContext.Items.ToListAsync();
            return items;
        }
    }
}
