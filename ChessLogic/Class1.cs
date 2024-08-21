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
        public Player SquareColor()
        {
            if ((Row + Columm) % 2 == 0)
            {
                return Player.White;
            }
            return Player.Black;
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Columm == position.Columm;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Columm);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }
    }
}
