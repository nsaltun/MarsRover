using MarsRover.Logic;
using MarsRover.Logic.enums;
using MarsRover.Constants;
using MarsRover.Logic.Command;
using MarsRover.Logic.Direction;
using System;
using System.Collections.Generic;

namespace MarsRover
{
    /// <summary>
    /// MarsRover
    /// </summary>
    public class MarsRover : InputValidation, IMarsRover
    {
        public List<Rover> rovers;
        public Plateau plateau;
        public MarsRover(string input)
        {
            Initialize(input);
        }

        private void Initialize(string input)
        {
            string[] inputValues = ParseInput(input);
            SetPlateau(inputValues[0]);
            SetRovers(inputValues);
            CommandBase.CreateCommands();
            DirectionBase.CreateDirections();
        }

        public void ExplorePlateau()
        {
            foreach (Rover rover in rovers)
            {
                rover.Explore();
                rover.PrintRoverPosition();
            }
        }

        private string[] ParseInput(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                throw new ArgumentException(Errors.EmptyInput);
            }

            string[] inputValues = input.Split('\n');

            if (inputValues.Length < CommonConstants.TotalInputCount)
            {
                throw new ArgumentException(Errors.InsufficientInputParameters);
            }

            return inputValues;
        }

        private void SetPlateau(string plateauInput)
        {
            ValidatePlateau(plateauInput);
            string[] plateauInfo = plateauInput.Split(' ');
            plateau = new Plateau()
            {
                X = Convert.ToInt32(plateauInfo[0]),
                Y = Convert.ToInt32(plateauInfo[1])
            };
        }

        private void SetRovers(string[] inputValues)
        {
            rovers = new List<Rover>();
            for (int i = 1; i < inputValues.Length; i += 2)
            {
                rovers.Add(new Rover(plateau)
                {
                    Position = SetRoverPosition(inputValues[i]),
                    Commands = inputValues[i + 1]
                });
            }
        }

        private Position SetRoverPosition(string positionInput)
        {
            ValidatePosition(positionInput, plateau);
            string[] positionInfo = positionInput.Split(' ');
            return new Position()
            {
                X = Convert.ToInt32(positionInfo[0]),
                Y = Convert.ToInt32(positionInfo[1]),
                Facing = (DirectionType)Enum.Parse(typeof(DirectionType), positionInfo[2])
            };
        }
    }
}
