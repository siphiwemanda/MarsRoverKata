namespace MarsRoverKata
{
    public class NorthState : IState
    {
        private const int MaxY = 9;
        private const int MinY = 0;
        private int _x;
        private int _y;
        private Grid _grid;

        public NorthState(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public string Direction => "N";
        public string Position => $"{_x}:{_y}";

        public IState Rotate(char command)
        {
            return command == 'R' ? (IState) new EastState(_x,_y) : new WestState(_x, _y);
        }

        public IState Move()
        {
            _grid.Move(0, 2);
            return this;
            return _y == MinY ? new NorthState(_x, MaxY) : new NorthState(_x, _y - 1);
        }
    }
}