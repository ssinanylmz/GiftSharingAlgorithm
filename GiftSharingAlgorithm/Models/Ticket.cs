using System;
using System.Collections.Generic;
using System.Text;

namespace GiftSharingAlgorithm.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public Gift Gift { get; set; }
    }
}
