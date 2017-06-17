using System;

namespace MarsRoverKata.Models
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public Rover(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public void MoveForward()
        {
            switch(Direction)
            {
                case Direction.North:
                    Y += 1;
                    break;
                case Direction.South:
                    Y -= 1;
                    break;
                case Direction.East:
                    X += 1;
                    break;
                case Direction.West:
                    X -= 1;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case Direction.North:
                    Direction = Direction.West;
                    break;
                case Direction.South:
                    Direction = Direction.East;
                    break;
                case Direction.East:
                    Direction = Direction.North;
                    break;
                case Direction.West:
                    Direction = Direction.South;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void MoveBackward()
        {
            TurnLeft();
            TurnLeft();
            MoveForward();
            TurnLeft();
            TurnLeft();
        }

        public void TurnRight()
        {
            TurnLeft();
            TurnLeft();
            TurnLeft();
        }
    }
}
