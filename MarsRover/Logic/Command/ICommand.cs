using MarsRover.Logic;

namespace MarsRover.Logic.Command
{
    public interface ICommand
    {
        void Apply(Rover rover);
    }
}
