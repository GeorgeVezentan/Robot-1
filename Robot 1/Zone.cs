using Robot_1.GiantKillerRobotApp.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiantKillerRobotApp
{
    public class Zone
    {
        public string Name { get; set; }
        public List<Target> Targets { get; set; }

        public Zone(string name, List<Target> targets)
        {
            Name = name;
            Targets = targets;
        }
    }
}
