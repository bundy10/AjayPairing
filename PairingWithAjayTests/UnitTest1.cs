using Moq;
using PairingWithAjay;
using PairingWithAjay.Interfaces;

namespace PairingWithAjayTests;

public class GameTest
{
    private readonly Mock<IComputerStrategy> _mockComputerStrategy;
    private readonly Mock<IOutput> _mockOutput;
    private readonly Game _game;


    public GameTest()
    {
        _mockComputerStrategy = new Mock<IComputerStrategy>();
        _mockOutput = new Mock<IOutput>();
        _game = new Game(_mockComputerStrategy.Object, _mockOutput.Object);
    }
    
    [Fact]
    public void GivenPlayGameIsCalledWhenPlayer1SelectionIs1ThenOutputWillCallWinner()
    {
        
        //Arrange
        _mockComputerStrategy.Setup(selection => selection.GetSelection()).Returns(1);

        //Act
        _game.PlayGame();

        //Assert
        _mockOutput.Verify(winner => winner.Winner(), Times.Once());
    }
}