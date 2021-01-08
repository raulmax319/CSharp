using chessBoard;

namespace Game {
    class Rook : Piece {

        public Rook(Board board, Color color) : base(board, color) {
        }

        private bool canMove(Position pos) {
            Piece p = board.piece(pos);
            return p == null || p.color != this.color;
        }

        public override bool[,] possibleMoves() {
            bool[,] mat = new bool[board.lines, board.columns];

            Position pos = new Position(0, 0);

            //up
            pos.direction(pos.line - 1, pos.column);
            while(board.validPosition(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != color) break;
                
                pos.line = pos.line - 1;
            }

            //down
            pos.direction(pos.line + 1, pos.column);
            while(board.validPosition(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != color) break;
                
                pos.line = pos.line + 1;
            }

            //right
            pos.direction(pos.line, pos.column + 1);
            while(board.validPosition(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != color) break;
                
                pos.column = pos.column + 1;
            }

            //left
            pos.direction(pos.line, pos.column - 1);
            while(board.validPosition(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != color) break;
                
                pos.column = pos.column - 1;
            }
            return mat;
        }

        public override string ToString() {
            return "R ";
        }
    }
}