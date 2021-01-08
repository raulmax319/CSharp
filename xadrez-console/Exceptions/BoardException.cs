using System;

namespace chessBoard {
    class BoardException : Exception {

        public BoardException(string msg) : base(msg) {
        }
    }
}