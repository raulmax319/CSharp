using System;
using chessBoard;

namespace Game {
    class Chess {

        public Board board { get; private set; }
        private int turn;
        private Color actualPlayer; 
        public bool finished { get; private set; }

        public Chess() {
            board = new Board(8, 8);
            turn = 1;
            actualPlayer = Color.White;
            finished = false;
            spawnPieces();
        }

        public void moveExecution(Position origin, Position target) {
            Piece p = board.removePiece(origin);
            p.incrementNumOfMoves();
            Piece captured = board.removePiece(target);
            board.insertPiece(p, target);
        }

        private void spawnPieces() {
            board.insertPiece(new Rook(board, Color.Black), new BoardPosition('a', 3).toPosition());
            board.insertPiece(new King(board, Color.Black), new BoardPosition('c', 4).toPosition());

            board.insertPiece(new Rook(board, Color.White), new BoardPosition('h', 3).toPosition());
        }
    }
}