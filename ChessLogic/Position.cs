
namespace ChessLogic;

public class Position
{
    public int Row { get; }
    public int Column { get; }

    public Position(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public Player SquareColor()
    {
        if ((Row + Column) % 2 == 0)
        {
            return Player.White;
        }
        else
        {
            return Player.Black;
        }
    }

    public override bool Equals(object obj)
    {
        if (obj is Position position)
        {
            return Row == position.Row && Column == position.Column;
        }
        else
        {
            return false;
        }
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Row, Column);
    }

    public static bool operator ==(Position left, Position right)
    {
        return EqualityComparer<Position>.Default.Equals(left, right);
    }

    public static bool operator !=(Position left, Position right)
    {
        return !(left == right);
    }

    public static Position operator +(Position pos, Direction dir)
    {
        return new Position(pos.Row + dir.RowDelta, pos.Column + dir.ColumnDelta);
    }
}
