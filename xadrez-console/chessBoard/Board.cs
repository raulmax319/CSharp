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

        public Piece piece(Position pos) {
            return pieces[pos.line, pos.column];
        }

        public void insertPiece(Piece p, Position pos) {
            if(pieceExists(pos)) throw new BoardException("There's already a piece in this position.");
            
            pieces[pos.line, pos.column] = p;
            p.position = pos;
        }

        public Piece removePiece(Position pos) {
            if(piece(pos) == null) return null;

            Piece aux = piece(pos);
            aux.position = null;
            pieces[pos.line, pos.column] = null;
            return aux;
        }

        public bool pieceExists(Position pos) {
            validatePosition(pos);

            return piece(pos) != null;
        }

        public bool validPosition(Position pos) {
            if(pos.line < 0 || pos.line >= lines || pos.column < 0 || pos.column >= columns) return false;
            
            return true;
        }

        public void validatePosition(Position pos) {
            if(!validPosition(pos)) throw new BoardException("Invalid Position!");
        }
    }
}