using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadboard.Logic.Gates
{
    public class GateNot : Gate
    {
        public GateNot(string Name) : base(Name) { }

        public override bool Evaluate(bool[] inputs)
        {
            if (inputs.Length == 1)
            {
                return !inputs[0];
            }
            else
            {
                throw new ArgumentException(string.Format("NOT Gate expects 1 argument, but received {0} arguments", inputs.Length));
            }
        }
    }
}
