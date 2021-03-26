namespace MarsRoverKata
{
    public class WestState : IState
    {
        private int _x;
        private int _y;

        public WestState(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public string Direction => "W";
        public string Position => $"{_x}:{_y}";

        public IState Rotate(char command)
        {
            return command == 'R' ? (IState) new NorthState(_x,_y) : new SouthState(_x,_y);
        }

        public IState Move()
        {
            return new WestState(_x - 1, _y);
        }
    }
}