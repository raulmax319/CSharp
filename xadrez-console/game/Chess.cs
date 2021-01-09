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
        public bool check { get; private set; }

        public Chess() {
            board = new Board(8, 8);
            turn = 1;
            actualPlayer = Color.White;
            finished = false;
            check = false;
            pieces = new HashSet<Piece>();
            captured = new HashSet<Piece>();
            spawnPieces();
        }

        public Piece moveExecution(Position origin, Position target) {
            Piece p = board.removePiece(origin);
            p.incrementNumOfMoves();
            Piece capturedPiece = board.removePiece(target);
            board.insertPiece(p, target);

            if(capturedPiece != null) captured.Add(capturedPiece);

            return capturedPiece;
        }

        public void undoMove(Position o, Position t, Piece captPiece) {
            Piece p = board.removePiece(t);
            p.decrementNumOfMoves();

            if(captPiece != null) {
                board.insertPiece(captPiece, t);
                captured.Remove(captPiece);
            }
            board.insertPiece(p, o);
        }

        public void move(Position origin, Position target) {
            Piece captPiece = moveExecution(origin, target);

            if(isCheck(actualPlayer)) {
                undoMove(origin, target, captPiece);
                throw new BoardException("You can't check yourself");
            }
            if(isCheck(opponent(actualPlayer))) {
                check = true;
                    if(isCheckMate(opponent(actualPlayer))) {
                        finished = true;
                    }
                    else {
                        turn++;
                        switchPlayer();
                    }
            }
            else {
                check = false;
            }
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

        private Color opponent(Color c) {
            if(c == Color.White) return Color.Black;
            else return Color.White;
        }
        private Piece king(Color c) {
            foreach(Piece p in piecesInGame(c)) {
                if( p is King) return p;
            }
            return null;
        }

        public bool isCheck(Color c) {
            Piece K = king(c);
            if(K == null) throw new BoardException("No King??");

            foreach(Piece p in piecesInGame(opponent(c))) {
                bool[,] mat = p.possibleMoves();

                if(mat[K.position.line, K.position.column]) return true;
            }
            return false;
        }

        public bool isCheckMate(Color c) {
            if(!isCheck(c)) return false;

            foreach(Piece p in piecesInGame(c)) {
                bool[,] mat = p.possibleMoves();
                for(int i = 0; i < board.lines; i++) {
                    for(int j = 0; j < board.columns; j++) {
                        if(mat[i, j]) {
                            Position origin = p.position;
                            Position target = new Position(i, j);
                            Piece capturedPiece = moveExecution(origin, target);
                            bool test = isCheck(c);
                            undoMove(origin, target, capturedPiece);
                            
                            if(!test) return false;
                        }
                    }
                }
            }
            return true;
        }

        public void addNewPiece(char col, int line, Piece p) {
            board.insertPiece(p, new BoardPosition(col, line).toPosition());
            pieces.Add(p);
        }

        private void spawnPieces() {
            //white
            addNewPiece('c', 1, new Rook(board, Color.White));
            addNewPiece('h', 7, new Rook(board, Color.White));
            //addNewPiece('b', 1, new Knight(board, Color.White));
            //addNewPiece('c', 1, new Bishop(board, Color.White));
            //addNewPiece('d', 1, new Queen(board, Color.White));
            addNewPiece('d', 1, new King(board, Color.White));
            //addNewPiece('f', 1, new Bishop(board, Color.White));
            //addNewPiece('g', 1, new Knight(board, Color.White));
            //addNewPiece('h', 1, new Rook(board, Color.White));

            //black
            //addNewPiece('c', 8, new Rook(board, Color.Black));
            //addNewPiece('b', 8, new Knight(board, Color.Black));
            //addNewPiece('c', 8, new Bishop(board, Color.Black));
            //addNewPiece('d', 8, new Queen(board, Color.Black));
            addNewPiece('a', 8, new King(board, Color.Black));
            //addNewPiece('f', 8, new Bishop(board, Color.Black));
            //addNewPiece('g', 8, new Knight(board, Color.Black));
            addNewPiece('b', 8, new Rook(board, Color.Black));
        }
    }
}