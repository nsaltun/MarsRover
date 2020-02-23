using MarsRover.Logic;
using MarsRover.Constants;
using System;

namespace MarsRover
{
    public class InputValidation
    {
        protected void ValidatePlateau(string plateau)
        {
            string[] plateauCoordinates = plateau.Split(' ');

            if (plateauCoordinates.Length != CommonConstants.SpaceInputCount)
            {
                throw new ArgumentException(Errors.InsufficientPlateauCoordinates);
            }
            uint coordinate = 0;
            foreach (string plateauCoordinate in plateauCoordinates)
            {
                if (!uint.TryParse(plateauCoordinate, out coordinate))
                {
                    throw new ArgumentException(Errors.InvalidCoordinates);
                }
            }

        }

        protected void ValidatePosition(string positionInput, Plateau plateau)
        {
            if (!positionInput.Contains(" "))
            {
                throw new ArgumentException(Errors.EmptyPositionInput);
            }

            string[] posInfo = positionInput.Split(' ');

            if (posInfo.Length != CommonConstants.PositionInputCount)
            {
                throw new ArgumentException(Errors.InsufficientPositionInput);
            }

            uint coordinate = 0;

            if (!uint.TryParse(posInfo[0], out coordinate) || !uint.TryParse(posInfo[1], out coordinate))
            {
                throw new ArgumentException(Errors.InvalidCoordinates);
            }

            if (Convert.ToInt32(posInfo[0]) > plateau.X || Convert.ToInt32(posInfo[1]) > plateau.Y)
            {
                throw new ArgumentException(Errors.RoverNotInPlateau);
            }
        }
    }
}
