using InvoicesTask.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Context.Configuration
{
    public class StoreConfiguration
    {
        public StoreConfiguration(EntityTypeBuilder<Store> entity)
        {
            entity.HasData(
               new Store()
               {
                   ID=1,
                   Name ="HouseWares Store"
               } ,
               new Store()
               {
                   ID = 2,
                   Name = "Electricals store"
               },
               new Store()
               {
                   ID =3,
                   Name = "Cars Store"
               }
  
                );

        }
    }
}
