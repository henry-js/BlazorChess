using ChessLibrary;

namespace BlazorChess.Data;

public class ChessLibraryHelper
{
    public ChessBoard chessBoard { get; private set; } = new ChessBoard();
    public Cell[,] GetBoardState()
    {
        chessBoard.Init();
        return chessBoard.BoardState;
    }
}