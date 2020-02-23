using System;
using MarsRover.Logic;

namespace MarsRover.Logic.Direction
{
    public class South : IDirection
    {
        public void Apply(Rover rover)
        {
            rover.Position.Y--;
        }
    }
}
