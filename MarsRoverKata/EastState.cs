namespace MarsRoverKata
{
    public class EastState : IState
    {
        private readonly Grid _grid;
  
        public EastState(Grid grid)
        {
            _grid = grid;
        }

        public string Direction => "E";
        public string Position => $"{_grid.X}:{_grid.Y}";

        public IState Rotate(char command)
        {
            return command == 'R' ? (IState) new SouthState(_grid) : new NorthState(_grid);
        }

        public IState Move()
        {
            _grid.Move(1,0);
            return this;
        }
    }
}