using MarsRover.Logic;
using MarsRover.Logic.enums;

namespace MarsRover.Logic.Command
{
    public class TurnLeft : ICommand
    {
        public void Apply(Rover rover)
        {
            rover.Position.Facing = rover.Position.Facing == DirectionType.E ? DirectionType.N : rover.Position.Facing + 1;
        }
    }
}
