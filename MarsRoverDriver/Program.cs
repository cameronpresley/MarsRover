using System;
using System.Collections.Generic;
using MarsRoverKata;
using MarsRoverKata.Models;

namespace MarsRoverDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var component = new RoverComponent();
            var rover = component.Create();

            PrintLocation(rover);
            var command = GetValidInput();
            while (command != Command.Quit)
            {
                rover = component.ProcessCommand(command, rover);
                PrintLocation(rover);
                command = GetValidInput();
            }
            PrintLocation(rover);
        }

        private static void PrintLocation(Rover rover)
        {
            Console.WriteLine($"X: {rover.X}, Y: {rover.Y}, Direction: {rover.Direction}");
        }
        private static Command GetValidInput()
        {
            new List<string>
            {
                "Please choose a command:",
                "Move (F)orward",
                "Move (B)ackward",
                "Turn (L)eft",
                "Turn (R)ight",
                "(Q)uit"
            }.ForEach(Console.WriteLine);
            var command = ConvertChoiceToCommand(Console.ReadLine());
            return command == Command.Unknown ? GetValidInput() : command;
        }

        private static Command ConvertChoiceToCommand(string input)
        {
            if (input == null) return Command.Unknown;
            switch (input.ToLower())
            {
                case "f": return Command.MoveForward;
                case "b": return Command.MoveBackward;
                case "l": return Command.TurnLeft;
                case "r": return Command.TurnRight;
                case "q": return Command.Quit;
                default:
                    return Command.Unknown;
            }
        }
    }
}
