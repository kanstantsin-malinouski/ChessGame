using ChessLogic;
using System.Collections.Generic;

namespace ChessUI.Pages;

public static class Images
{
    private static readonly Dictionary<PieceType, string> whiteSources = new()
    {
        { PieceType.Pawn, "Assets/PawnW.png" },
        { PieceType.Bishop, "Assets/BishopW.png" },
        { PieceType.Knight, "Assets/KnightW.png" },
        { PieceType.Rook, "Assets/RookW.png" },
        { PieceType.Queen, "Assets/QueenW.png" },
        { PieceType.King, "Assets/KingW.png" },
    };

    private static readonly Dictionary<PieceType, string> blackSources = new()
    {
        { PieceType.Pawn, "Assets/PawnB.png" },
        { PieceType.Bishop, "Assets/BishopB.png" },
        { PieceType.Knight, "Assets/KnightB.png" },
        { PieceType.Rook, "Assets/RookB.png" },
        { PieceType.Queen, "Assets/QueenB.png" },
        { PieceType.King, "Assets/KingB.png" },
    };

    public static string GetImage(Player color, PieceType type)
    {
        return color switch
        {
            Player.White => whiteSources[type],
            Player.Black => blackSources[type],
            _ => null
        };
    }

    public static string GetImage(Piece piece)
    {
        if (piece == null)
        {
            return null;
        }

        return GetImage(piece.Color, piece.Type);
    }
}
