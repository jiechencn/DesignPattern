using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            CatRobot cat = new CatRobot
            {
                Brain = new Brain { Think = new Think { Width = "Poor" } },
                Body = new Body { Skin = new Skin { Color = "Black and white" } }
            };

            HumanRobot human = new HumanRobot
            {
                Brain = new Brain { Think = new Think { Width = "Good" } },
                Body = new Body { Skin = new Skin { Color = "Yellow" } }
            };


            RobotManager robotManager = new RobotManager();

            robotManager.Register("cat", cat);
            robotManager.Register("human", human);

            AbstractRobotPrototype robot1a = robotManager.Create("cat");
            AbstractRobotPrototype robot1b = robotManager.Create("cat");
            robot1b.Brain = new Brain { Think = new Think { Width = "Good" } };
            robot1b.Body = new Body { Skin = new Skin { Color = "Colorful" } };

            AbstractRobotPrototype robot2a = robotManager.Create("human");
            AbstractRobotPrototype robot2b = robotManager.Create("human");
            robot2b.Brain = new Brain { Think = new Think { Width = "Poor" } };
            robot2b.Body = new Body { Skin = new Skin { Color = "Black" } };

            Console.WriteLine(robot1a.ToString());
            Console.WriteLine(robot1b.ToString());
            Console.WriteLine(robot2a.ToString());
            Console.WriteLine(robot2b.ToString());
        }
    }
}
