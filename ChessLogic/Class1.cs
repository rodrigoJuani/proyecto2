﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Position
    {
        public int Row { get;}
        public int Columm { get;}
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
