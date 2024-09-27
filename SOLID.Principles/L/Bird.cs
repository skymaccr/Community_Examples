
/// <summary>
/// Liskov Substitution Principle (LSP)
/// Definition: Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.
/// </summary>
namespace SOLID.Principles.L
{
    public class Bird_Wrong
    {
        public virtual void Fly() {
            Console.WriteLine("Flying logic");
        }
    }

    public class Seagul_Wrong : Bird_Wrong
    {
        public override void Fly()
        {
            base.Fly();
        }
    }

    public class Ostrich_Wrong : Bird_Wrong
    {
        public override void Fly()
        {
            throw new NotImplementedException();
        }
    }


    public abstract class Bird
    {
        public abstract void Move();
    }

    public class Seagul : Bird
    {
        public override void Move() {
            Console.WriteLine("Flying logic");
        }
    }

    public class Ostrich : Bird
    {
        public override void Move() {
            Console.WriteLine("Walking logic");
        }
    }
}
