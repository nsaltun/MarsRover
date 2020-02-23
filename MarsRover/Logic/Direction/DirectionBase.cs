
using MarsRover.Logic.enums;
using System.Collections.Generic;

namespace MarsRover.Logic.Direction
{
    public class DirectionBase
    {
        public static Dictionary<DirectionType, IDirection> Directions { get; set; }

        public static void CreateDirections()
        {
            Directions = new Dictionary<DirectionType, IDirection>();
            Directions.Add(DirectionType.N, new North());
            Directions.Add(DirectionType.W, new West());
            Directions.Add(DirectionType.S, new South());
            Directions.Add(DirectionType.E, new East());
        }
    }
}
