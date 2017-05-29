using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadboard.Logic
{
    public abstract class Gate : LogicItem
    {
        public Gate(string name) : base(name) { }

        public abstract override bool Evaluate(bool[] inputs);
    }
}
