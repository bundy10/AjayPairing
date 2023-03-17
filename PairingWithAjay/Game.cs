using PairingWithAjay.Interfaces;

namespace PairingWithAjay;

public class Game
{
    private readonly IComputerStrategy _computerStrategy;
    private readonly IOutput _output;

    public Game(IComputerStrategy computerStrategy, IOutput output)
    {
        _computerStrategy = computerStrategy;
        _output = output;
    }
    
    public void PlayGame()
    {
        var player1Selection = _computerStrategy.GetSelection();

        if (player1Selection == 1)
        {
            _output.Winner();
        }
    }
}