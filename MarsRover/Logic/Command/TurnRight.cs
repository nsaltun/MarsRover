using MarsRover.Logic;
using MarsRover.Logic.enums;

namespace MarsRover.Logic.Command
{
    public class TurnRight : ICommand
    {
        public void Apply(Rover rover)
        {
            rover.Position.Facing = rover.Position.Facing == DirectionType.N ? DirectionType.E : rover.Position.Facing - 1;
        }
    }
}
