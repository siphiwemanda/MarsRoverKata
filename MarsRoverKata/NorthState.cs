namespace MarsRoverKata
{
    public class NorthState : IState
    {
        private readonly Grid _grid;

        public NorthState(Grid grid)
        {
            _grid = grid;
        }

        public string Direction => "N";
        public string Position => $"{_grid.X}:{_grid.Y}";

        public IState Rotate(char command)
        {
            return command == 'R' ? (IState) new EastState(_grid) : new WestState(_grid);
        }

        public IState Move()
        {
            _grid.Move(0,-1);
            return this;
        }
    }
}