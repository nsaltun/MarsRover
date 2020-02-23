using System;
using MarsRover.Logic;

namespace MarsRover.Logic.Direction
{
    public class West : IDirection
    {
        public void Apply(Rover rover)
        {
            rover.Position.X--;
        }
    }
}
