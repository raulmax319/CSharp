using System;
using chessBoard;
using Game;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args) {
            try {
                Board board = new Board(8, 8);

                board.insertPiece(new Rook(board, Color.Black), new Position(0, 0));
                board.insertPiece(new Rook(board, Color.Black), new Position(1, 3));
                board.insertPiece(new King(board, Color.Black), new Position(3, 4));

                Screen.printBoard(board);
            }
            catch(BoardException err) {
                System.Console.WriteLine(err.Message);
            }
        }
    }
}
