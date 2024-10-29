using System;
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
                PieceType.King=>'q',
            };
        }
    }
}
