namespace MarsRover
{
    public class FacingWest : ICardinalDirection
    {
        public DirectionName Name { get; } = DirectionName.West;

        public ICardinalDirection TurnLeft()
        {
            return new FacingSouth();
        }

        public ICardinalDirection TurnRight()
        {
            return new FacingNorth();
        }

        public ISquare GetSquareLocationInfront(ISquare currentSquare, IGrid grid)
        {
            var newColumn = (currentSquare.Column - 1).Equals(0) ? grid.Columns : currentSquare.Column - 1;
            return grid.Find(currentSquare.Row, newColumn);
        }

        public ISquare GetSquareLocationBehind(ISquare currentSquare, IGrid grid)
        {
            var newColumn = (currentSquare.Column - 1).Equals(0) ? grid.Columns : currentSquare.Column - 1;
            return grid.Find(currentSquare.Row, newColumn);
        }
    }
}