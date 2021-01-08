using Game;

namespace chessBoard {
    abstract class Piece {
        
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int numberOfMoves { get; protected set; }
        public Board board { get; protected set; }

        public Piece(Board board, Color color) {
            this.position = null;
            this.board = board;
            this.color = color;
            this.numberOfMoves = 0;
        }

        public abstract bool[,] possibleMoves();

        public void incrementNumOfMoves() {
            numberOfMoves++;
        }
    }
}