using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Trading.Core.Models;

namespace Trading.Core
{
    public class InventoryManager
    {
        public List<Inventory> StockInventory{ get; private set;}

        public InventoryManager()
        {
            if (StockInventory.Count() <=0)
            {
                foreach(var sec in GetSecurities())
                {
                    StockInventory.Add(new Inventory(){
                        SecurityId = sec.Name,
                        Positions = Random.Next(100,1000)
                    });
                }               
            }            
        }

        public UpdateInventory(Inventory inventory, InventoryAction action){
            var securityToUpdate = StockInventory.Where(x=>x.SecurityId == inventory.SecurityId).FirstOrDefault();
            if(action.ToString() == "Add")
            { 
                //TBC - will there be any limit on upper side of stck
                securityToUpdate.Positions += inventory.Positions;
            }
            else
            {
                securityToUpdate.Positions -= inventory.Positions;
            }
        }

        public static IEnumerable<Securities> GetSecurities(){
            return new List<Securities>(){
                new Securities{Name="Infosys", SecurityId="INF"},
                new Securities{Name="Reliance", SecurityId="INF"},
                new Securities{Name="ITC", SecurityId="ITC"},
                new Securities{Name="Tata Motars", SecurityId="TMR"}
            };
        }

        public enum InventoryAction{
            Add,
            Remove
        }
    }

}