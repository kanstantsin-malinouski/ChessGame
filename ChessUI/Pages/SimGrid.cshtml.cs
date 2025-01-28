using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChessLogic;
using System.Drawing;
using ChessUI.Pages;

namespace ChessUI;

public class SimGridModel : PageModel
{
    //private Piece[,] board = new Piece[8, 8]; // Replace with your actual board initialization

    //public Piece GetPieceAt(int row, int col)
    //{
    //    return board[row, col]; // Return the piece at this position
    //}

    public string[,] pieceImages = new string[8, 8];
    public bool[,] highlights = new bool[8, 8];
    private Dictionary<Position, Move> moveCache = new Dictionary<Position, Move>();

    private GameState gameState;
    private Position? selectedPos = null;

    public void OnGet()
    {
        InitializeBoard();

        gameState = new GameState(Player.White, Board.Initial());
        DrawBoard(gameState.Board);
        SetCursor(gameState.CurrentPlayer);
    }

    private void InitializeBoard()
    {
        for (int r = 0; r < 8; r++)
        {
            for (int c = 0; c < 8; c++)
            {
                pieceImages[r, c] = null;
                highlights[r, c] = false;
            }
        }
    }

    private void DrawBoard(Board board)
    {
        for (int r = 0; r < 8; r++)
        {
            for (int c = 0; c < 8; c++)
            {
                var piece = board[r, c];
                pieceImages[r, c] = piece != null ? Images.GetImage(piece) : null;
            }
        }
    }

        public void OnPostMouseDown(int x, int y)
        {
            double squareSize = 600 / 8; // 600px board width, 8 squares
            int row = (int)(y / squareSize);
            int col = (int)(x / squareSize);
            Position pos = new Position(row, col);

            if (selectedPos == null)
            {
                OnFromPositionSelected(pos);
            }
            else
            {
                OnToPositionSelected(pos);
            }
        }

        private void OnFromPositionSelected(Position pos)
        {
            IEnumerable<Move> moves = gameState.LegalMovesForPiece(pos);

            if (moves.Any())
            {
                selectedPos = pos;
                CacheMoves(moves);
                ShowHighlights();
            }
        }

        private void OnToPositionSelected(Position pos)
        {
            selectedPos = null;
            HideHighlights();

            if (moveCache.TryGetValue(pos, out Move move))
            {
                HandleMove(move);
            }
        }

        private void HandleMove(Move move)
        {
            gameState.MakeMove(move);
            DrawBoard(gameState.Board);
            SetCursor(gameState.CurrentPlayer);
        }

        private void CacheMoves(IEnumerable<Move> moves)
        {
            moveCache.Clear();

            foreach (Move move in moves)
            {
                moveCache[move.ToPos] = move;
            }
        }

        private void ShowHighlights()
        {
            Color color = Color.FromArgb(150, 125, 255, 125);    

            foreach (Position pos in moveCache.Keys)
            {
                highlights[pos.Row, pos.Column] = true;
            }
        }

        private void HideHighlights()
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    highlights[r, c] = false;
                }
            }
        }

        private void SetCursor(Player player)
        {
            string cursorUrl = player == Player.White ? "/Assets/CursorW.cur" : "/Assets/CursorB.cur";
            HttpContext.Response.Headers.Add("Set-Cursor", cursorUrl);
        }
}
