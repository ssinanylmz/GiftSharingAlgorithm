using GiftSharingAlgorithm.Models;
using System.Collections.Generic;

namespace GiftSharingAlgorithm.Data
{
    public class ProductData
    {
        public List<Product> Products()
        {
            var giftList = new List<Product>(){
            new Product {
                         Id = 1,
                         Code = "ATA",
                         Name = "Atatürk Portresi ",
                         Count = 15,
                         CountInFirstGroup = 5
                     },
            new Product {
                         Id = 2,
                         Code = "USB ",
                         Name = "USB Bellek",
                         Count = 20,
                         CountInFirstGroup = 10,
            },
            new Product {
                         Id = 3,
                         Code = "PWB",
                         Name = "Powerbank ",
                         Count = 25,
                         CountInFirstGroup = 8
                     }
            };
            return giftList;
        }
    }

}
