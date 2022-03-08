using System;
using System.Linq;

namespace Trading.Core.Models
{
    public class TradeTransaction
    {
        public int TransactionId { get; set; }
        public Trade Trade { get; set; } //TBC can single transaction have multiple trades, buy 4 infy, sell 4 rel etc?
        public User User { get; set; }
        public DateTime CreateTs { get; set; }
    }
}