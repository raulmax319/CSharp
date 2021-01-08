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

        public bool existsPossibleMove() {
            bool[,] mat = possibleMoves();
            for(int i = 0; i < board.lines; i++){
                for(int j = 0; j < board.columns; j++) {
                    if(mat[i, j]) return true;
                }
            }
            return false;
        }

        public bool canMoveTo(Position pos) {
            return possibleMoves()[pos.line, pos.column];
        }

        public abstract bool[,] possibleMoves();

        public void incrementNumOfMoves() {
            numberOfMoves++;
        }
    }
}