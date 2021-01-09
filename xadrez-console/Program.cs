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
                    try {
                        Console.Clear();
                        Screen.printGame(game);

                        System.Console.WriteLine();
                        System.Console.Write("Origin: ");
                        Position origin = Screen.readPiecePos().toPosition();
                        game.validateOriginPos(origin);

                        bool[,] possiblePos = game.board.piece(origin).possibleMoves();

                        Console.Clear();
                        Screen.printBoard(game.board, possiblePos);

                        System.Console.WriteLine();
                        System.Console.Write("Target: ");
                        Position target = Screen.readPiecePos().toPosition();
                        game.validateTargetPos(origin, target);

                        game.move(origin, target);
                    }
                    catch(BoardException error) {
                        System.Console.WriteLine(error.Message);
                        System.Console.ReadLine();
                    }
                }
                Console.Clear();
                Screen.printGame(game);
            }
            catch(BoardException err) {
                System.Console.WriteLine(err.Message);
            }
        }
    }
}
