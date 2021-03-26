namespace MarsRoverKata
{
    public class NorthState : IState
    {
        private int _x;
        private int _y;

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
            throw new System.NotImplementedException();
        }
    }
}