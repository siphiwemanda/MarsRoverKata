namespace MarsRoverKata
{
    public interface IState
    {
        string Direction { get; }
        string Position { get; }
        IState Rotate(char command);
        IState Move();
    }
}