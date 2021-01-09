using chessBoard;

namespace Game {
    class Knight : Piece {

        public Knight(Board board, Color color) :base(board, color) {
        }

        private bool canMove(Position pos) {
            Piece p = board.piece(pos);
            return p == null || p.color != this.color;
        }

        public override bool[,] possibleMoves() {
            bool[,] mat = new bool[board.lines, board.columns];

            Position pos = new Position(0, 0);

            pos.location(position.line - 1, position.column - 2);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;
            
            pos.location(position.line - 2, position.column - 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;
            
            pos.location(position.line - 2, position.column + 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;
            
            pos.location(position.line - 1, position.column + 2);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            pos.location(position.line + 1, position.column + 2);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;
            
            pos.location(position.line + 2, position.column +1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            pos.location(position.line + 2, position.column - 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            pos.location(position.line + 1, position.column - 2);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;
            
            return mat;
        }

        public override string ToString() {
            return " N ";
        }
    }
}