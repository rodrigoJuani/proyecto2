﻿using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using ChessLogic;

namespace ChessUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Image[,] pieceImages = new Image[8, 8];
        private readonly Rectangle[,] highlights = new Rectangle[8, 8];
        private readonly Dictionary<Position, Move> moveCache = new Dictionary<Position, Move>();
        private GameState gameState;
        private Position selectedPos = null;
        public MainWindow()
        {
            InitializeComponent();//este es un comentario
            InitializeBoard();

            gameState = new GameState(Player.White, Board.Initial());
            DrawBoard(gameState.Board);
        }
        private void InitializeBoard()
        {
            for(int r = 0; r < 8; r++)
            {
                for(int c = 0; c < 8; c++)
                {
                    Image image = new Image();
                    pieceImages[r, c] = image;
                    PieceGrid.Children.Add(image);
                }
            }
        }
        private void DrawBoard(Board board)
        {
            for(int r = 0; r < 8; r++)
            {
                for(int c = 0; c < 8; c++)
                {
                    Piece piece = board[r, c];
                    pieceImages[r, c].Source = Images.GetImage(piece);
                }
            }
        }
     }
    
}