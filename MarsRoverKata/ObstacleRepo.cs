using System.Collections.Generic;

namespace MarsRoverKata
{
    public class ObstacleRepo
    {
        public List<ObstacleClass> obsticalList;

        public ObstacleRepo()
        {

            obsticalList = new List<ObstacleClass>();
        }

        public ObstacleRepo AddObstacle(int x, int y)
        {
            obsticalList.Add(new ObstacleClass(x,y));
            return this;
        }

    }
}