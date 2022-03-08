using System;
using System.Linq;

namespace Trading.Core.Models
{
    public class Inventory
    {
        public string SecurityId { get; set; }
        public int Positions { get; set; }
    }
}