using System;
using MarsRover.Logic;

namespace MarsRover.Logic.Direction
{
    public class East : IDirection
    {
        public void Apply(Rover rover)
        {
            rover.Position.X++;
        }
    }
}
