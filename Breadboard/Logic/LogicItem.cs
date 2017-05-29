using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadboard.Logic
{
    public abstract class LogicItem
    {
        public string Name;

        public LogicItem(string name)
        {
            this.Name = name;
        }

        public abstract bool Evaluate(bool[] inputs);
    }
}
