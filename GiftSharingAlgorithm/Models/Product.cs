using System;
using System.Collections.Generic;
using System.Text;

namespace GiftSharingAlgorithm.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int CountInFirstGroup { get; set; }

    }
}
