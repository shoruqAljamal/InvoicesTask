using InvoicesTask.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesTask.Context.Configuration
{
    public class ItemConfiguration
    {
        public ItemConfiguration(EntityTypeBuilder<Item> entity)
        {
            entity.HasData(
                new Item()
                {
                    ID =1,
                    Name = "Closet",
                    Barcode="123q",
                    Price =60.0

                },
                new Item()
                 {
                     ID = 2,
                     Name = "Bed",
                     Barcode = "123w",
                     Price = 99.9

                },
                 new Item()
                 {
                     ID = 3,
                     Name = "Desk",
                     Barcode = "123e",
                     Price = 50.50

                },
                 new Item()
                  {
                      ID = 4,
                      Name = "Door",
                      Barcode = "123r",
                      Price = 73.50

                },
                 new Item()
                  {
                       ID = 5,
                       Name = "Vacuum Cleaner",
                       Barcode = "123t",
                       Price = 80.0

                   },
                  new Item()
                   {
                      ID = 6,
                      Name = "BMW",
                      Barcode = "123y",
                      Price = 300.0

                   }

                );
            
        }
    }
}
