using MarsRover.Logic.enums;
using System;
using MarsRover.Constants;
using MarsRover.Logic.Command;

namespace MarsRover.Logic
{
    /// <summary>
    /// Rover
    /// </summary>
    public class Rover : IRover
    {
        public string Commands { get; set; }
        public Position Position { get; set; }
        private Plateau plateau { get; set; }

        public Rover(Plateau plateau)
        {
            this.plateau = plateau;
        }
        
        public void Explore()
        {
            foreach (char command in Commands)
            {
                CommandType commandType;
                if (!Enum.TryParse<CommandType>(command.ToString(), out commandType))
                {
                    throw new ArgumentException(Errors.InvalidCommandValue, command.ToString());
                }

                CheckIsRoverInPlateau();
                CommandBase.Commands[commandType].Apply(this);
            }
        }

        public void PrintRoverPosition()
        {
            Console.WriteLine($"{Position.X} {Position.Y} {Position.Facing}");
        }

        private void CheckIsRoverInPlateau()
        {
            if (Position.X > plateau.X || Position.Y > plateau.Y)
            {
                throw new ApplicationException($"{Errors.RoverNotInPlateau} Rover position:({Position.X},{Position.Y}); plateau:[{plateau.X},{plateau.Y}]");
            }
        }

    }
}
