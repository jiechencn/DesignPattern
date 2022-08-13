using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class RobotManager
    {
        private IDictionary<string, AbstractRobotPrototype> robots = new Dictionary<string, AbstractRobotPrototype>();

        public void Register(string robotType, AbstractRobotPrototype robot)
        {
            robots.Add(robotType, robot);
        }

        public AbstractRobotPrototype Create(string robotType)
        {
            if (robots.TryGetValue(robotType, out var robot))
            {
                return robot.CreateClone();
            }
            return null;
        }
    }
}
