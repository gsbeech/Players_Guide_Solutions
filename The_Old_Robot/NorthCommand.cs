using System;
using System.Collections.Generic;
using System.Text;

namespace The_Old_Robot
{
    class NorthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.Y++;
            }
        }
    }
}
