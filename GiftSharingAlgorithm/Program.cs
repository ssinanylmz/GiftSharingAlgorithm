using GiftSharingAlgorithm.Methods;

namespace GiftSharingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalGiftTicket = 200; 
            int firstGroupCount = 50;
            var tickets = TicketManager.TicketGenerator(totalGiftTicket);
            var sharedTicket = TicketManager.GenerateTicketWithGift(tickets, firstGroupCount);
            int i = 1;
            foreach (var item in sharedTicket)
            {
                FileManager.WriteLog("MixedTicket.txt",(i++)+" - "+item.Number + "-" + item.Gift.Name);
            }
        }
    }
}
