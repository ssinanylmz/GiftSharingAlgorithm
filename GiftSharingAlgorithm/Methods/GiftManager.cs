using System;
using System.Collections.Generic;
using System.Linq;
using GiftSharingAlgorithm.Data;
using GiftSharingAlgorithm.Extensions;
using GiftSharingAlgorithm.Models;

namespace GiftSharingAlgorithm.Methods
{
    public class GiftManager
    {
        
        public static List<Gift> GiftListGenerator(bool isGroup) {

            ProductData productData = new ProductData();
            var products = productData.Products();

            List<Gift> giftList = new List<Gift>();
            
            foreach (var product in products)
            {
                int count = isGroup ? product.CountInFirstGroup : product.Count-product.CountInFirstGroup;
                for (int i = 1; i <= count; i++)
                {
                    Gift gift = new Gift();
                    gift.Id = i;
                    gift.Code = product.Code;
                    gift.Name = product.Name;
                    giftList.Add(gift);
                }
            }
            return giftList;
        }
        public static List<Ticket> GiftRandomize(List<Ticket> tickets, List<Gift> gifts)
        {
            gifts.Shuffle(); // Hediyeler kendi içinde karıştırılır.
            for (int i = 0; i < tickets.Count; i++) // Her hangi bir grup ayrımı olmadığı için bilet listesine hediyeler dağıtılır.
            {
                var ticket = tickets.Where(x => x.Id == i).FirstOrDefault();
                if (i < gifts.Count)
                    ticket.Gift = gifts.GetRange(i, 1).First();
                else
                    ticket.Gift = new Gift();
            }
            tickets.Shuffle(); // Tüm hediyeler dağıtıldıktan sonra bilet listesi karıştırılır.
            return tickets;
        }
        public static List<Ticket> FirstGroupRandomize(List<Ticket> tickets, List<Gift> gifts, int firstGroupCount)
        {
            var secondGiftGroup = GiftListGenerator(false);
            var ListOne = TicketManager.CreateTicketGroups(gifts, firstGroupCount);
            var ListTwo = TicketManager.CreateTicketGroups(secondGiftGroup, tickets.Count - firstGroupCount);

            ListOne.AddRange(ListTwo);
            return ListOne;
        }
    }
}
