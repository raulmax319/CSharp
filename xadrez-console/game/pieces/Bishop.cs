using System;
using chessBoard;

namespace Game {
    class Bishop : Piece {

        public Bishop(Board board, Color color) :base(board, color) {
        }

        private bool canMove(Position pos) {
            Piece p = board.piece(pos);
            return p == null || p.color != this.color;
        }

        public override bool[,] possibleMoves() {
            bool[,] mat = new bool[board.lines, board.columns];

            Position pos = new Position(0, 0);

            //up-left
            pos.location(position.line - 1, position.column - 1);
            while(board.validPosition(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != this.color) break;
                
                pos.location(pos.line - 1, pos.column - 1);
            }

            //up-right
            pos.location(position.line - 1, position.column + 1);
            while(board.validPosition(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != this.color) break;
                
                pos.location(pos.line - 1, pos.column + 1);
            }

            //down-left
            pos.location(position.line + 1, position.column - 1);
            while(board.validPosition(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != this.color) break;
                
                pos.location(pos.line + 1, pos.column - 1);
            }

            //down-right
            pos.location(position.line + 1, position.column - 1);
            while(board.validPosition(pos) && canMove(pos)) {
                mat[pos.line, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != this.color) break;
                
                pos.location(pos.line + 1, pos.column - 1);
            }
            return mat;
        }

        public override string ToString() {
            return " B ";
        }
    }
}