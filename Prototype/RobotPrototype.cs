using System;

namespace Prototype
{
    public abstract class AbstractRobotPrototype
    {
        public Brain Brain { get; set; }
        public Body Body { get; set; }
        public virtual AbstractRobotPrototype CreateClone()
        {
            return this.MemberwiseClone() as AbstractRobotPrototype;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} = {this.GetHashCode()}: Brain={Brain.Think.Width}, Body={Body.Skin.Color}";
        }
    }

    public class Body
    {
        public Skin Skin { get; set; }
    }

    public class Skin
    {
        public string Color { get; set; }
    }

    public class Brain
    {
        public Think Think { get; set; }
    }

    public class Think
    {
        public string Width { get; set; }
    }

    public class CatRobot : AbstractRobotPrototype
    {
    }

    public class HumanRobot : AbstractRobotPrototype
    {
        //public override AbstractRobotPrototype CreateClone()
        //{
        //    // customized clone or deep clone
        //}
    }
}