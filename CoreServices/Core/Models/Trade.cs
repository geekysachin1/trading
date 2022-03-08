using System;
using System.Linq;

namespace Trading.Core.Models
{
    public class Trade
    {
        public int TradeId { get; set; }
        public TradeAction Action { get; set; }
        public int Positions { get; set; }
        public string SecurityId { get; set; }
        public DateTime CreateTs { get; set; }
    }

    public enum TradeAction
    {
        Buy,
        Sell,
        Cancel
    }
}