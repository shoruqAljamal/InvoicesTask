using InvoicesTask.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Context.Configuration
{
    public class CustomerConfiguration
    {
        public CustomerConfiguration(EntityTypeBuilder<Customer> entity)
        {

            entity.HasData(
                
                new Customer()
                {
                ID =1,
                Name = "Ahmad",
            
                },
                new Customer()
                {
                    ID=2,
                    Name="Anas"
                }
                );
            
           
        }
    }
}
