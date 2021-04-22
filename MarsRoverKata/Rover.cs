namespace MarsRoverKata
{
    public class Rover
    {
        private IState _state;

 
        public Rover()
        {
            _state = new SouthState(0, 0);
        }
        
        public string Execute(string commands)
        {
            foreach (var command in commands)
            {
                if (command != 'M')
                {
                    _state = _state.Rotate(command);
                }
                if (command == 'M')
                {
                    _state = _state.Move();
             
                }
            }

            return $"{_state.Position}:{_state.Direction}";
        }

    }
}