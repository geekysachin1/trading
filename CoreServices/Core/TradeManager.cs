using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Trading.Core.Models;
using Trading.Queue.Processor;

namespace Trading.Core
{
    public class TradeManager
    {
        private Processor _queueProcessor;
        public TradeManager(Processor queueProcesssor)
        {
            _queueProcessor = queueProcesssor;
        }
        public bool ExecuteTrade(TradeTransaction transaction){
            //put the transaction in queue
            _queueProcessor.Put(transaction);
            //read queue and generate event based on trade type
            //update the user portfolio, inventory
            

        }
    }

}