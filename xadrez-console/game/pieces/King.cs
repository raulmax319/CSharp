using chessBoard;

namespace Game {
    class King : Piece {

        private Chess chess;

        public King(Board board, Color color, Chess c) :base(board, color) {
            this.chess = c;
        }

        private bool canMove(Position pos) {
            Piece p = board.piece(pos);
            return p == null || p.color != this.color;
        }

        private bool castleTest(Position pos) {
            Piece p = board.piece(pos);
            return p != null && p is Rook && p.color == color && p.numberOfMoves == 0;
        }

        public override bool[,] possibleMoves() {
            bool[,] mat = new bool[board.lines, board.columns];

            Position pos = new Position(0, 0);

            //up
            pos.location(position.line - 1, position.column);
            if(board.validPosition(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
            }

            //up-right
            pos.location(position.line - 1, position.column + 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            //right
            pos.location(position.line, position.column + 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            //down-right
            pos.location(position.line + 1, position.column + 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            //down
            pos.location(position.line + 1, position.column);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            //down-left
            pos.location(position.line + 1, position.column - 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            //left
            pos.location(position.line, position.column - 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;

            //up-left
            pos.location(position.line - 1, position.column - 1);
            if(board.validPosition(pos) && canMove(pos))
                mat[pos.line, pos.column] = true;
            
            //Castle
            if(numberOfMoves == 0 && !this.chess.check) {
                Position rookPos1 = new Position(position.line, position.column + 3);
                if(castleTest(rookPos1)) {
                    Position p1 = new Position(position.line, position.column + 1);
                    Position p2 = new Position(position.line, position.column + 2);
                    if(board.piece(p1) == null && board.piece(p2) == null) {
                        mat[position.line, position.column + 2] = true;
                    }
                }
                Position rookPos2 = new Position(position.line, position.column - 4);
                if(castleTest(rookPos2)) {
                    Position p1 = new Position(position.line, position.column - 1);
                    Position p2 = new Position(position.line, position.column - 2);
                    Position p3 = new Position(position.line, position.column - 3);
                    if(board.piece(p1) == null && board.piece(p2) == null && board.piece(p3) == null) {
                        mat[position.line, position.column - 2] = true;
                    }
                }
            }

            return mat;
        }

        public override string ToString() {
            return " K ";
        }
    }
}