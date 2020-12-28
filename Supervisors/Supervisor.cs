using AutoMapper;
using InvoicesTask.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Supervisors
{
    public partial class Supervisor : ISupervisor
    {

        private readonly IMapper _mapper;
        private readonly ICustomerRepo _ICustomerRepo;
        private readonly IItemRepo _IItemRepo;
        private readonly IInvoiceRepo _IInvoiceRepo;
        private readonly IStoreRepo _IStoreRepo;

        public Supervisor(IMapper mapper,ICustomerRepo ICustomerRepo,
                          IItemRepo IItemRepo, IInvoiceRepo IInvoiceRepo,
                          IStoreRepo IStoreRepo)

        {
            _mapper = mapper;
            _ICustomerRepo = ICustomerRepo;
            _IInvoiceRepo = IInvoiceRepo;
            _IItemRepo = IItemRepo;
            _IStoreRepo = IStoreRepo;
        }



    }
}
