using System.Collections.Generic;
using GiftSharingAlgorithm.Models;
using System.Linq;
using GiftSharingAlgorithm.Extensions;

namespace GiftSharingAlgorithm.Methods
{
    public class TicketManager
    {
        public static List<Ticket> TicketGenerator(int ticketCount)
        {
            List<Ticket> tickets = new List<Ticket>();

            for (int i = 0; i < ticketCount; i++)
            {
                tickets.Add(new Ticket {
                Id=i,
                Number=1
            });
            }
            return tickets;
        }
        public static List<Ticket> GenerateTicketWithGift(List<Ticket> tickets,int firstGroupCount)
        {
            if (firstGroupCount == tickets.Count)
            {
                var gifts = GiftManager.GiftListGenerator(false);
                return GiftManager.GiftRandomize(tickets, gifts);
            }
            else if(firstGroupCount<tickets.Count)
            {
                var gifts = GiftManager.GiftListGenerator(true);
                return GiftManager.FirstGroupRandomize(tickets, gifts, firstGroupCount);
            }
            return null;
        }
        public static List<Ticket> CreateTicketGroups(List<Gift> gifts,int count)
        {
            List<Ticket> tickets = new List<Ticket>();

            for (int i = 0; i < count; i++)
            {
                Ticket ticket = new Ticket();
                ticket.Id = i;
                ticket.Number = 100000+i;
                if (i < gifts.Count)
                    ticket.Gift = gifts.GetRange(i, 1).First();
                else
                    ticket.Gift = new Gift();
                tickets.Add(ticket);
            }
            tickets.Shuffle();
            return tickets;
        }
    }
}
