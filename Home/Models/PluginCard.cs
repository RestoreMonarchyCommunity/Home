using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoreMonarchy.Home.Models
{
    public class PluginCard
    {
        public PluginCard(string name, string iconName)
        {
            Name = name;
            IconName = iconName;
        }

        public PluginCard() { }

        public string Name { get; set; }
        public string IconName { get; set; }
    }
}
