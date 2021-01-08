using System;
using chessBoard;
using Game;

namespace xadrez_console {
    class Screen {
        public static void printBoard(Board board) {
            for(int i = 0; i < board.lines; i++) {
                System.Console.Write($"{8 - i} ");
                for(int j = 0; j < board.columns; j++) {
                    if(board.piece(i, j) == null) 
                        System.Console.Write("- ");
                    else {
                        printPiece(board.piece(i, j));
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("  A B C D E F G H");
        }

        public static BoardPosition readPiecePos() {
            string s = System.Console.ReadLine();
            char col = s[0];
            int line = int.Parse($"{s[1]}");

            return new BoardPosition(col, line);
        }

        public static void printPiece(Piece piece) {
            if(piece.color == Color.White)
                System.Console.Write(piece);
            else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}