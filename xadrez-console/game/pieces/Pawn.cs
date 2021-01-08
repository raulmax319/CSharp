using chessBoard;

namespace Game {
    class Pawn : Piece {

        public Pawn(Board board, Color color) :base(board, color) {
        }

        public override bool[,] possibleMoves(){
            return null;
        }

        public override string ToString() {
            return "P ";
        }
    }
}