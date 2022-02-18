namespace MarsRoverKata
{
    public class SouthState : IState
    {
      
        private readonly Grid _grid;


        public SouthState(Grid grid)
        {
            _grid = grid;

        }

        public string Direction => "S";
        public string Position => $"{_grid.X}:{_grid.Y}";
        
        public IState Rotate(char command)
        {
            return command == 'R' ? (IState) new WestState(_grid) : new EastState(_grid);
        }

        public IState Move()
        {
            _grid.Move(0,1);
            return new SouthState(_grid);
        }

        
    }
}