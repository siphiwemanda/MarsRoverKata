namespace MarsRoverKata
{
    public class EastState : IState
    {
        private int _x;
        private int _y;

        public EastState(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public string Direction => "E";
        public string Position => $"{_x}:{_y}";

        public IState Rotate(char command)
        {
            return command == 'R' ? (IState) new SouthState(_x, _y) : new NorthState(_x, _y);
        }

        public IState Move()
        {
            return new EastState(_x + 1, _y);
        }
    }
}