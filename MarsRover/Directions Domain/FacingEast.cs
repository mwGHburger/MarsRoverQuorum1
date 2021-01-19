namespace MarsRover
{
    public class FacingEast : ICardinalDirection
    {
        public DirectionName Name { get; } = DirectionName.East;

        public ICardinalDirection TurnLeft()
        {
            return new FacingNorth();
        }

        public ICardinalDirection TurnRight()
        {
            return new FacingSouth();
        }
    }
}