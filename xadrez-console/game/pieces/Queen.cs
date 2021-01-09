using chessBoard;

namespace Game {
    class Queen : Piece {

        public Queen(Board board, Color color) :base(board, color) {
        }

        public override bool[,] possibleMoves(){
            return null;
        }

        public override string ToString() {
            return " Q ";
        }
    }
}