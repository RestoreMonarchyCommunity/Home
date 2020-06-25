using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoreMonarchy.Home.Models
{
    public class PaidPluginCard : PluginCard
    {
        public PaidPluginCard(string name, string iconName, decimal price)
        {
            Name = name;
            IconName = iconName;
            Price = price;
        }

        public decimal Price { get; set; }
    }
}
