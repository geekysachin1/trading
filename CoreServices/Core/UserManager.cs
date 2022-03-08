using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Trading.Core.Models;

namespace Trading.Core
{
    public class UserManager
    {
        public List<Portfolio> Portfolio { get; private set; }
        public bool Login(string userId, string password)
        {
            return true;
        }

        public Portfolio GetPorfolio(string userId){
            return Portfolio.Where(x=> x.UserId == userId);
        }

        public Portfolio UpdatePorfolio(Portfolio portfolio, PortfolioAction action){
            //
            switch(action){
                case PortfolioAction.Add:
                    Portfolio.Add(portfolio);
                case PortfolioAction.Update:
                    var folioToUpdate = Portfolio.Where(x=> x.UserId == portfolio.UserId && x.SecurityId= portfolio.SecurityId).FirstOrDefault();
                    folioToUpdate.Positions = portfolio.Positions;
                case PortfolioAction.Remove:
                    Portfolio.Remove(portfolio);
                default:
                    return;
            }
        }

        public enum PortfolioAction{
            Add,
            Update,
            Remove
        }
    }

}