namespace MarsRover
{
    public class FacingSouth : ICardinalDirection
    {
        public DirectionName Name { get; } = DirectionName.South;
        public ICardinalDirection TurnLeft()
        {
            return new FacingEast();
        }
    }
}