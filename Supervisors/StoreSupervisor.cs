using InvoicesTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Supervisors
{
    public partial class Supervisor
    {
        public async Task<List<StoreModel>> GetAllStores()
        {
            var stores = await _IStoreRepo.GetAllStores();
            return _mapper.Map<List<StoreModel>>(stores);
        }
    }
}
