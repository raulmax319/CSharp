using System;
using chessBoard;
using Game;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args) {
            try {
                Chess game = new Chess();

                while(!game.finished) {
                    Console.Clear();
                    Screen.printBoard(game.board);

                    System.Console.WriteLine();
                    System.Console.Write("Origin: ");
                    Position origin = Screen.readPiecePos().toPosition();
                    System.Console.Write("Target: ");
                    Position target = Screen.readPiecePos().toPosition();

                    game.moveExecution(origin, target);
                }
            }
            catch(BoardException err) {
                System.Console.WriteLine(err.Message);
            }
        }
    }
}
