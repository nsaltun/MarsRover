using MarsRover.Logic.enums;
using System.Collections.Generic;

namespace MarsRover.Logic.Command
{
    public class CommandBase
    {
        public static Dictionary<CommandType, ICommand> Commands { get; set; }

        public static void CreateCommands()
        {
            Commands = new Dictionary<CommandType, ICommand>();
            Commands.Add(CommandType.L, new TurnLeft());
            Commands.Add(CommandType.R, new TurnRight());
            Commands.Add(CommandType.M, new Move());
        }
    }
}
