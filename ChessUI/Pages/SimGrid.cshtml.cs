using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChessLogic;
using System.Drawing;

namespace ChessUI.Pages
{
    public partial class SimGridModel : PageModel
    {

    //    public string GetImagePath(char symbol) => _symbolToImagePath.ContainsKey(symbol) ? _symbolToImagePath[symbol] : "/images/many.png";

        //private readonly Image[,] pieceImages = new Image[8, 8];
        //private void InitializeBoard()
        //{
        //    for (int r = 0; r < 8; r++)
        //    {
        //        for (int c = 0; c < 8; c++)
        //        {
        //            Image image = new Image();
        //            pieceImages[r, c] = image;
        //            PieceGrid.Children.Add(image);
        //        }
        //    }
        //}

        //public static ImageSource GetImage(Player color, PieceType type) 
        //{
        //    return color switch 
        //    {
        //        Player.White => whiteSources[type],
        //        Player.Black => blackSources[type],
        //        _ => null
        //    }
        //}

        //public static ImageSource GetImage(Piece piece) 
        //{
        //    if (piece == null)
        //    {
        //        return null;
        //    }
        //    else 
        //    {
        //        return GetImage(piece.Color, piece.Type);
        //    }
        //}

        //private void DrawBoard(Board board) 
        //{
        //    for (int r = 0; r < 8; r++) 
        //    {
        //        for (int c = 0; c < 8; c++) 
        //        {
        //            Piece piece = board[r, c];
        //            PieceImages[r, c].Source = Images.GetImage(piece);
        //        }
        //    }
        //}
        public void OnGet()
        {
        }
    }
}
