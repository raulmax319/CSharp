using System;
using chessBoard;

namespace xadrez_console {
    class Screen {
        public static void printBoard(Board board) {
            for(int i = 0; i < board.lines; i++) {
                for(int j = 0; j < board.columns; j++) {
                    if(board.piece(i, j) == null) 
                        System.Console.Write("- ");
                    else 
                        System.Console.Write($"{board.piece(i, j)} ");
                }
                System.Console.WriteLine();
            }
        }
    }
}