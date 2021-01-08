using System;
using chessBoard;
using Game;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args) {

            BoardPosition pos = new BoardPosition('c', 7);
            System.Console.WriteLine(pos);
            System.Console.WriteLine(pos.toPosition());
        }
    }
}
