using System.Collections.Generic;
using chessBoard;

namespace Game {
    class Chess {

        public Board board { get; private set; }
        public int turn { get; private set; }
        public Color actualPlayer { get; private set; }
        public bool finished { get; private set; }

        private HashSet<Piece> pieces;
        private HashSet<Piece> captured;

        public Chess() {
            board = new Board(8, 8);
            turn = 1;
            actualPlayer = Color.White;
            finished = false;
            pieces = new HashSet<Piece>();
            captured = new HashSet<Piece>();
            spawnPieces();
        }

        public void moveExecution(Position origin, Position target) {
            Piece p = board.removePiece(origin);
            p.incrementNumOfMoves();
            Piece capturedPiece = board.removePiece(target);
            board.insertPiece(p, target);

            if(capturedPiece != null) captured.Add(capturedPiece);
        }

        public void doMove(Position origin, Position target) {
            moveExecution(origin, target);
            turn++;
            switchPlayer();
        }

        public void validateOriginPos(Position pos) {
            if(board.piece(pos) == null) throw new BoardException("The block you choose contains no piece.");
            if(actualPlayer != board.piece(pos).color) throw new BoardException($"This piece is not yours.");
            if(!board.piece(pos).existsPossibleMove()) throw new BoardException("There's no possible moves for the chosen piece");
        }

        public void validateTargetPos(Position origin, Position target) {
            if(!board.piece(origin).canMoveTo(target)) throw new BoardException("Invalid target position.");
        }

        private void switchPlayer() {
            if(actualPlayer == Color.White) actualPlayer = Color.Black;
            else actualPlayer = Color.White;
        }

        public HashSet<Piece> capturedPieces(Color color) {
            HashSet<Piece> aux = new HashSet<Piece>();
            
            foreach(Piece p in captured) {
                if(p.color == color) aux.Add(p);
            }
            return aux;
        }

        public HashSet<Piece> piecesInGame(Color color) {
            HashSet<Piece> aux = new HashSet<Piece>();
            
            foreach(Piece p in pieces) {
                if(p.color == color) aux.Add(p);
            }
            aux.ExceptWith(capturedPieces(color));
            return aux;
        }

        public void addNewPiece(char col, int line, Piece p) {
            board.insertPiece(p, new BoardPosition(col, line).toPosition());
            pieces.Add(p);
        }

        private void spawnPieces() {
            //white
            addNewPiece('a', 1, new Rook(board, Color.White));
            addNewPiece('b', 1, new Knight(board, Color.White));
            addNewPiece('c', 1, new Bishop(board, Color.White));
            addNewPiece('d', 1, new Queen(board, Color.White));
            addNewPiece('e', 1, new King(board, Color.White));
            addNewPiece('f', 1, new Bishop(board, Color.White));
            addNewPiece('g', 1, new Knight(board, Color.White));
            addNewPiece('h', 1, new Rook(board, Color.White));

            //black
            addNewPiece('a', 8, new Rook(board, Color.Black));
            addNewPiece('b', 8, new Knight(board, Color.Black));
            addNewPiece('c', 8, new Bishop(board, Color.Black));
            addNewPiece('d', 8, new Queen(board, Color.Black));
            addNewPiece('e', 8, new King(board, Color.Black));
            addNewPiece('f', 8, new Bishop(board, Color.Black));
            addNewPiece('g', 8, new Knight(board, Color.Black));
            addNewPiece('h', 8, new Rook(board, Color.Black));
        }
    }
}