public class Board
{
    private char[,] _board;
    private const int Size = 3;

    public Board()
    {
        _board = new char[Size, Size];
        for (int i = 0; i < Size; i++)
            for (int j = 0; j < Size; j++)
                _board[i, j] = '.';
    }

    public void Display()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
                Console.Write(_board[i, j] + " ");
            Console.WriteLine();
        }
    }

    public bool TryPlaceMark(int row, int col, char symbol)
    {
        if (row >= 0 && row < Size && col >= 0 && col < Size && _board[row, col] == '.')
        {
            _board[row, col] = symbol;
            return true;
        }
        return false;
    }

    public bool CheckForWin(char symbol)
    {
        // Check rows
        for (int i = 0; i < Size; i++)
            if (_board[i, 0] == symbol && _board[i, 1] == symbol && _board[i, 2] == symbol)
                return true;

        // Check columns
        for (int j = 0; j < Size; j++)
            if (_board[0, j] == symbol && _board[1, j] == symbol && _board[2, j] == symbol)
                return true;

        // Check diagonals
        if (_board[0, 0] == symbol && _board[1, 1] == symbol && _board[2, 2] == symbol)
            return true;
        if (_board[0, 2] == symbol && _board[1, 1] == symbol && _board[2, 0] == symbol)
            return true;

        return false;
    }

    public bool IsBoardFull()
    {
        for (int i = 0; i < Size; i++)
            for (int j = 0; j < Size; j++)
                if (_board[i, j] == '.')
                    return false;
        return true;
    }
}
