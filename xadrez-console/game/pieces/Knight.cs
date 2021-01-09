using chessBoard;

namespace Game {
    class Knight : Piece {

        public Knight(Board board, Color color) :base(board, color) {
        }

        public override bool[,] possibleMoves(){
            return null;
        }

        public override string ToString() {
            return " N ";
        }
    }
}