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
            //add castling rights
            sb.Append(' ');
            //Add en passant data
        }
        private static char PieceChar(Piece piece)
        {
            char c = piece.Type switch
            {
                PieceType.Pawn => 'p',
                PieceType.Knight=>'n',
                PieceType.Rook=>'r',
                PieceType.Bishop=>'b',
                PieceType.King=>'k',
                PieceType.Queen=>'q',
                _=>' '
            };
            if (piece.Color == Player.White)
            {
                return char.ToUpper(c);
            }
            return c;
        }
        private void AddRowData(Board board,int row)
        {
            int empty = 0;
            for(int c = 0; c < 0; c++)
            {
                if (board[row, c] == null)
                {
                    empty++;
                    continue;
                }
                if (empty > 0)
                {
                    sb.Append(empty);
                    empty = 0;
                }
                sb.Append(PieceChar(board[row, c]));
            }
            if (empty > 0)
            {
                sb.Append(empty);
            }
        }
        private void AddPiecePlacement(Board board)
        {
            for(int r = 0; r < 8; r++)
            {
                AddRowData(board, r);
            }
        }
    }
}
