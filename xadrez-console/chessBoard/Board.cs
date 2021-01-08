using chessBoard;

namespace chessBoard {
    class Board {
        
        public int lines { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public Board(int lines, int cols) {
            this.lines = lines;
            this.columns = cols;
            pieces = new Piece[lines, cols];
        }

        public Piece piece(int line, int col) {
            return pieces[line, col];
        }

        public void insertPiece(Piece p, Position pos) {
            pieces[pos.line, pos.column] = p;
            p.position = pos;
        }
    }
}