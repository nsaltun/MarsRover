using MarsRover.Logic.Direction;
using MarsRover.Logic;

namespace MarsRover.Logic.Command
{
    public class Move : ICommand
    {
        public void Apply(Rover rover)
        {
            DirectionBase.Directions[rover.Position.Facing].Apply(rover);
        }
    }
}
