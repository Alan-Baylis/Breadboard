using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadboard.Logic
{
    /// <summary>
    /// This class is used as a starting point for any input to Gate objects. They can output both 'true' and 'false'
    /// as determined by the Breadboard. This way, we can generate a truth table based on all Input objects.
    /// </summary>
    public class Input : LogicItem
    {
        public Input(string name) : base(name) { }

        /// <summary>
        /// Accepts one boolean value as input and returns that value. This is how the Breadboard can generate both
        /// 'true' and 'false' values for Input objects (to generate a truth table).
        /// </summary>
        public override bool Evaluate(bool[] inputs)
        {
            if (inputs.Length == 1)
            {
                return inputs[0];
            }
            else
            {
                throw new ArgumentException(string.Format("Input expects 1 argument, but received {0} arguments", inputs.Length));
            }
        }
    }
}
