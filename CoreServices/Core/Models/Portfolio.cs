using System;
using System.Linq;

namespace Trading.Core.Models
{
    public class Portfolio
    {
        public string UserId { get; set; }
        public string SecurityId { get; set; }
        public int Positions { get; set; }
    }
}