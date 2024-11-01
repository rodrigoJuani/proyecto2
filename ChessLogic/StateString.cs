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
            AddPiecePlacement(board);
            sb.Append(' ');
            AddCurrentPlayer(currentPlayer);
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
                if (r != 0)
                {
                    sb.Append('/');
                }
                AddRowData(board, r);
            }
        }
        private void AddCurrentPlayer(Player currentPlayer)
        {
            if (currentPlayer == Player.White)
            {
                sb.Append('w');
            }
            else
            {
                sb.Append('b');
            }
        }
        private void AddCastlingRights(Board board)
        {
            bool castleWKS = board.CastleRightKS(Player.White);
            bool castleWQS = board.CastleRightQS(Player.White);
            bool castleBKS = board.CastleRightKS(Player.Black);
            bool castleBQS = board.CastleRightQS(Player.Black);

            if(!(castleWKS || castleWQS || castleBKS|| castleBQS))
            {
                sb.Append('-');
                return;
            }
        }
    }
}
