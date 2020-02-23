using System;
using MarsRover.Logic;
using MarsRover.Logic.enums;

namespace MarsRover.Logic.Direction
{
    public class North : IDirection
    {
        public void Apply(Rover rover)
        {
            rover.Position.Y++;
        }
    }
}
