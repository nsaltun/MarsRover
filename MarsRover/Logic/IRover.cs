namespace MarsRover.Logic
{
    /// <summary>
    /// Rover Interface
    /// </summary>
    public interface IRover
    {
        /// <summary>
        /// Rover explore in plateau by their commands
        /// </summary>
        void Explore();

        /// <summary>
        /// Print rover position after applied all commands
        /// </summary>
        void PrintRoverPosition();
    }
}