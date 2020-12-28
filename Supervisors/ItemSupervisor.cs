using InvoicesTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Supervisors
{
    public partial class Supervisor
    {
        public async Task<List<ItemModel>> GetAllItems()
        {
            var items = await _IItemRepo.GetAllItems();
            return _mapper.Map<List<ItemModel>>(items);
        }
    }
}
