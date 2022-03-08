using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Trading.Core.Models;
using Trading.Core;

namespace Trading.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TradeController : ControllerBase
    {
         private readonly ILogger<TradeController> _logger;
        public TradeController(ILogger<TradeController> logger, TradeManager tradeManager)
        {
            _logger = logger;
            _tradeManager = tradeManager;
        }

        [HttpPost]
        public ActionResult Execute(TradeTransaction transaction){

        }
    }
}
