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
            pos.location(position.line - 1, position.column);
            while(board.validPosition(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != this.color) break;
                
                pos.line = pos.line - 1;
            }

            //down
            pos.location(position.line + 1, position.column);
            while(board.validPosition(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != this.color) break;
                
                pos.line = pos.line + 1;
            }

            //right
            pos.location(position.line, position.column + 1);
            while(board.validPosition(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != this.color) break;
                
                pos.column = pos.column + 1;
            }

            //left
            pos.location(position.line, position.column - 1);
            while(board.validPosition(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != this.color) break;
                
                pos.column = pos.column - 1;
            }
            return mat;
        }

        public override string ToString() {
            return "R ";
        }
    }
}