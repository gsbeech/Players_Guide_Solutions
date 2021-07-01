using System;

namespace The_Old_Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            int numberOfCommandsToAccept = 3;
            Console.WriteLine("Please write 1 to turn the Robot On");
            var powerInput = Console.ReadLine();
            int powerInputAsInt = int.Parse(powerInput);
            if (powerInputAsInt == 1)
            {
                OnCommand onCommand = new OnCommand();
                onCommand.Run(robot);
            }
            for (int i = 0; i < numberOfCommandsToAccept; i++)
            { 
                Console.WriteLine("Select a direction for the Robot to move (n/e/s/w)");
                var input = Console.ReadLine();
                char inputAsChar = char.Parse(input);

                switch (inputAsChar)
                {
                    case 'n':
                        NorthCommand northCommand = new NorthCommand();
                        northCommand.Run(robot);
                        break;
                    case 'e':
                        EastCommand eastCommand = new EastCommand();
                        eastCommand.Run(robot);
                        break;
                    case 's':
                        SouthCommand southCommand = new SouthCommand();
                        southCommand.Run(robot);
                        break;
                    case 'w':
                        WestCommand westCommand = new WestCommand();
                        westCommand.Run(robot);
                        break;
                    default:
                        Console.WriteLine("Invalid character entered, please enter one of: n/e/s/w");
                        break;
                }
                Console.WriteLine($"[{robot.X} {robot.Y} {robot.IsPowered}]");
            }
        }
    }
}
