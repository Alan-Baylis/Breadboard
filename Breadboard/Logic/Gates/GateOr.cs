using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadboard.Logic.Gates
{
    public class GateOr : Gate
    {
        public GateOr(string Name) : base(Name) { }

        public override bool Evaluate(bool[] inputs)
        {
            if (inputs.Length < 2)
            {
                throw new ArgumentException(string.Format("OR Gate expects 2+ arguments, but received {0} arguments", inputs.Length));
            }
            else
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    if (inputs[i] == true)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}
