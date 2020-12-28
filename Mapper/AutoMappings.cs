using AutoMapper;
using InvoicesTask.Entities;
using InvoicesTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Mapper
{
    public class AutoMappings : Profile
    {

        public AutoMappings()
        {
            CreateMap<Customer, CustomerModel>().ReverseMap();
            CreateMap<Invoice, InvoiceModel>().ReverseMap();
            CreateMap<Item, ItemModel>().ReverseMap();
            CreateMap<Store, StoreModel>().ReverseMap();
            CreateMap<InvoiceItem, InvoiceItemModel>().ReverseMap();


        }
    }
}
