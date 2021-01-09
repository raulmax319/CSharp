using chessBoard;

namespace Game {
    class Pawn : Piece {

        public Pawn(Board board, Color color) :base(board, color) {
        }

        private bool enemyExists(Position pos) {
            Piece p = board.piece(pos);

            return p != null && p.color != color;
        }

        private bool free(Position p) {
            return board.piece(p) == null;
        }

        public override bool[,] possibleMoves() {
            bool[,] mat = new bool[board.lines, board.columns];

            Position pos = new Position(0, 0);
            
            if(color == Color.White) {
                pos.location(position.line - 1, position.column);
                if(board.validPosition(pos) && free(pos))
                    mat[pos.line, pos.column] = true;
                
                pos.location(position.line - 2, position.column);
                if(board.validPosition(pos) && free(pos) && numberOfMoves == 0)
                    mat[pos.line, pos.column] = true;
                
                pos.location(position.line - 1, position.column - 1);
                if(board.validPosition(pos) && enemyExists(pos))
                    mat[pos.line, pos.column] = true;
                
                pos.location(position.line - 1, position.column + 1);
                if(board.validPosition(pos) && enemyExists(pos))
                    mat[pos.line, pos.column] = true;
            }
            else {
                pos.location(position.line + 1, position.column);
                if(board.validPosition(pos) && free(pos))
                    mat[pos.line, pos.column] = true;
                
                pos.location(position.line + 2, position.column);
                if(board.validPosition(pos) && free(pos) && numberOfMoves == 0)
                    mat[pos.line, pos.column] = true;
                
                pos.location(position.line + 1, position.column - 1);
                if(board.validPosition(pos) && enemyExists(pos))
                    mat[pos.line, pos.column] = true;
                
                pos.location(position.line + 1, position.column + 1);
                if(board.validPosition(pos) && enemyExists(pos))
                    mat[pos.line, pos.column] = true;
            }
            return mat;
        }

        public override string ToString() {
            return " P ";
        }
    }
}