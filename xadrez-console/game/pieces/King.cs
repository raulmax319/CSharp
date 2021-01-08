using chessBoard;

namespace Game {
    class King : Piece {

        public King(Board board, Color color) :base(board, color) {
        }

        private bool canMove(Position pos) {
            Piece p = board.piece(pos);
            return p == null || p.color != this.color;
        }

        public override bool[,] possibleMoves() {
            bool[,] mat = new bool[board.lines, board.columns];

            Position pos = new Position(0, 0);

            //up
            pos.direction(position.line - 1, position.column);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            //up-right
            pos.direction(position.line - 1, position.column + 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            //right
            pos.direction(position.line, position.column + 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            //down-right
            pos.direction(position.line + 1, position.column + 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            //down
            pos.direction(position.line + 1, position.column);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            //down-left
            pos.direction(position.line + 1, position.column - 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            //left
            pos.direction(position.line, position.column - 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            //up-left
            pos.direction(position.line - 1, position.column - 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            return mat;
        }

        public override string ToString() {
            return "K ";
        }
    }
}