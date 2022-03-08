using System;
using System.Linq;

namespace Trading.Core.Models
{
    public class TradeHistory
    {
        public int TradeId { get; set; }
        public int Version { get; set; }
        public DateTime CreateTs { get; set; }
    }
}