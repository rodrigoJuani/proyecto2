﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    internal class StateString
    {
        private readonly StringBuilder sb=new StringBuilder();
        public StateString(Player currentPlayer,Board board)
        {
            //add piece placement data
            sb.Append(' ');
            //add current player
            sb.Append(' ');
        }
    }
}
