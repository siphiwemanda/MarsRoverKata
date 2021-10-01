namespace MarsRoverKata
{
    public class WestState : IState
    {
        private readonly Grid _grid;

        public WestState(Grid grid)
        {
            _grid = grid;
        }

        public string Direction => "W";
        public string Position => $"{_grid.X}:{_grid.Y}";

        public IState Rotate(char command)
        {
            return command == 'R' ? (IState) new NorthState(_grid) : new SouthState(_grid);
        }

        public IState Move()
        {
            _grid.Move(-1,0);
            return new WestState(_grid);
        }
    }
}