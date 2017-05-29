using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadboard.Logic
{
    /// <summary>
    /// This class represents a physical "wire" connecting one logic object to another. It has a left side and a right
    /// side, and logic flows from left to right.
    /// </summary>
    public class Connector
    {
        public LogicItem Left;
        public LogicItem Right;

        public Connector(LogicItem left, LogicItem right)
        {
            this.Left = left;
            this.Right = right;
        }

        public override string ToString()
        {
            return string.Format("{0} -> {1}", Left, Right);
        }
    }
}
