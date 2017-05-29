using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadboard.Logic.Gates
{
    public class GateAnd : Gate
    {
        public GateAnd(string name) : base(name) { }

        public override bool Evaluate(bool[] inputs)
        {
            if (inputs.Length < 2)
            {
                throw new ArgumentException(string.Format("AND Gate expects 2+ arguments, but received {0} arguments", inputs.Length));
            }
            else
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    if (inputs[i] == false)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
