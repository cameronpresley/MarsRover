using System;
using MarsRoverKata.Models;

namespace MarsRoverKata
{
    public class RoverComponent
    {
        public Rover Create()
        {
            return new Rover(0, 0, Direction.North);
        }

        public Rover ProcessCommand(Command command, Rover rover)
        {
            switch (command)
            {
                case Command.MoveForward:
                    rover.MoveForward();
                    return rover;
                case Command.MoveBackward:
                    rover.MoveBackward();
                    return rover;
                case Command.TurnLeft:
                    rover.TurnLeft();
                    return rover;
                case Command.TurnRight:
                    rover.TurnRight();
                    return rover;
                default:
                    throw new ArgumentOutOfRangeException(nameof(command), command, null);
            }
        }
    }
}
