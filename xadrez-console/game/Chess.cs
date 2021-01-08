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
            board.insertPiece(new Rook(board, Color.Black), new BoardPosition('a', 8).toPosition());
            board.insertPiece(new Knight(board, Color.Black), new BoardPosition('b', 8).toPosition());
            board.insertPiece(new Bishop(board, Color.Black), new BoardPosition('c', 8).toPosition());
            board.insertPiece(new King(board, Color.Black), new BoardPosition('d', 8).toPosition());
            board.insertPiece(new Queen(board, Color.Black), new BoardPosition('e', 8).toPosition());
            board.insertPiece(new Bishop(board, Color.Black), new BoardPosition('f', 8).toPosition());
            board.insertPiece(new Knight(board, Color.Black), new BoardPosition('g', 8).toPosition());
            board.insertPiece(new Rook(board, Color.Black), new BoardPosition('h', 8).toPosition());
            
            board.insertPiece(new Pawn(board, Color.Black), new BoardPosition('a', 7).toPosition());
            board.insertPiece(new Pawn(board, Color.Black), new BoardPosition('b', 7).toPosition());
            board.insertPiece(new Pawn(board, Color.Black), new BoardPosition('c', 7).toPosition());
            board.insertPiece(new Pawn(board, Color.Black), new BoardPosition('d', 7).toPosition());
            board.insertPiece(new Pawn(board, Color.Black), new BoardPosition('e', 7).toPosition());
            board.insertPiece(new Pawn(board, Color.Black), new BoardPosition('f', 7).toPosition());
            board.insertPiece(new Pawn(board, Color.Black), new BoardPosition('g', 7).toPosition());
            board.insertPiece(new Pawn(board, Color.Black), new BoardPosition('h', 7).toPosition());
            
            board.insertPiece(new Rook(board, Color.White), new BoardPosition('a', 1).toPosition());
            board.insertPiece(new Knight(board, Color.White), new BoardPosition('b', 1).toPosition());
            board.insertPiece(new Bishop(board, Color.White), new BoardPosition('c', 1).toPosition());
            board.insertPiece(new King(board, Color.White), new BoardPosition('d', 1).toPosition());
            board.insertPiece(new Queen(board, Color.White), new BoardPosition('e', 1).toPosition());
            board.insertPiece(new Bishop(board, Color.White), new BoardPosition('f', 1).toPosition());
            board.insertPiece(new Knight(board, Color.White), new BoardPosition('g', 1).toPosition());
            board.insertPiece(new Rook(board, Color.White), new BoardPosition('h', 1).toPosition());

            board.insertPiece(new Pawn(board, Color.White), new BoardPosition('a', 2).toPosition());
            board.insertPiece(new Pawn(board, Color.White), new BoardPosition('b', 2).toPosition());
            board.insertPiece(new Pawn(board, Color.White), new BoardPosition('c', 2).toPosition());
            board.insertPiece(new Pawn(board, Color.White), new BoardPosition('d', 2).toPosition());
            board.insertPiece(new Pawn(board, Color.White), new BoardPosition('e', 2).toPosition());
            board.insertPiece(new Pawn(board, Color.White), new BoardPosition('f', 2).toPosition());
            board.insertPiece(new Pawn(board, Color.White), new BoardPosition('g', 2).toPosition());
            board.insertPiece(new Pawn(board, Color.White), new BoardPosition('h', 2).toPosition());
        }
    }
}