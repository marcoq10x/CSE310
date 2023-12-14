public class Game
{
    private Board _board;
    private Player _player1, _player2;
    private Player _currentPlayer;

    public Game()
    {
        _board = new Board();
        _player1 = new Player('X');
        _player2 = new Player('O');
        _currentPlayer = _player1; // Player 1 starts
    }

    public void Start()
    {
        bool gameWon = false;

        while (!gameWon && !_board.IsBoardFull())
        {
            _board.Display();
            Console.WriteLine($"Player {_currentPlayer.Symbol}'s turn. Enter row and column (0, 1, 2): ");
            int row = Convert.ToInt32(Console.ReadLine());
            int col = Convert.ToInt32(Console.ReadLine());

            if (_board.TryPlaceMark(row, col, _currentPlayer.Symbol))
            {
                if (_board.CheckForWin(_currentPlayer.Symbol))
                {
                    gameWon = true;
                    Console.WriteLine($"Player {_currentPlayer.Symbol} wins!");
                }
                else
                {
                    _currentPlayer = _currentPlayer.Symbol == _player1.Symbol ? _player2 : _player1;
                }
            }
            else
            {
                Console.WriteLine("Invalid move. Try again.");
            }
        }

        if (!_board.IsBoardFull())
        {
            _board.Display();
        }
        else
        {
            Console.WriteLine("It's a draw!");
        }
    }
}
