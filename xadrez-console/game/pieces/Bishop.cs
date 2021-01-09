using System;
using chessBoard;

namespace Game {
    class Bishop : Piece {

        public Bishop(Board board, Color color) :base(board, color) {
        }

        public override bool[,] possibleMoves(){
            return null;
        }

        public override string ToString() {
            return " B ";
        }
    }
}