﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadboard.Logic
{
    /// <summary>
    /// Contains a list of all the logic gates "placed" on the Breadboard. This class is also responsible for
    /// calculating the output and displaying the results of all logical evaluations on the board.
    /// </summary>
    public class Breadboard
    {
        private List<LogicItem> logicItems;

        public Breadboard()
        {
            logicItems = new List<LogicItem>();
        }
    }
}
