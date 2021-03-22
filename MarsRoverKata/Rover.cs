using System;

namespace MarsRoverKata
{
    public class Rover
    {
        public string Direction { get; set; }
        public string Position { get; set; }

        public Rover()
        {
            Direction = "S";
            Position = "0:0";
        }

      

        public string Execute(string commands)
        {
            foreach (var command in commands)
            {
                SetDirection(command);
            }

            if (commands.Contains("M"))
            {
                Position = "0:1";
            }

            return $"{Position}:{Direction}";
        }

        public void SetDirection(char command)
        {
            if (command == 'R')
                switch (Direction)
                {
                    case "S":
                        Direction = "W";
                        break;
                    case "W":
                        Direction = "N";
                        break;
                    case "N":
                        Direction = "E";
                        break;
                    case "E":
                        Direction = "S";
                        break;
                }

            if (command == 'L')
                switch (Direction)
                {
                    case "S":
                        Direction = "E";
                        break;
                    case "W":
                        Direction = "S";
                        break;
                    case "N":
                        Direction = "W";
                        break;
                    case "E":
                        Direction = "N";
                        break;
                }
        }

    
    }
}