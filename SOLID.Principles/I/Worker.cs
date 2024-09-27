
/// <summary>
/// I Interface Segregation Principle (ISP)
/// Definition: Clients should not be forced to depend on interfaces they do not use.
/// </summary>
namespace SOLID.Principles.I
{
    public interface IWorker_Wrong
    {
        void Work();
        void Eat();
    }

    public class Worker_Wrong : IWorker_Wrong
    {
        public void Work() { /* Working logic */ }
        public void Eat() { /* Eating logic */ }
    }

    public class Slave_Wrong : IWorker_Wrong
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Work() { /* Working logic */ }
    }

    public interface IWorkable
    {
        void Work();
    }

    public interface IFeedable
    {
        void Eat();
    }

    public class Worker : IWorkable, IFeedable
    {
        public void Work() { /* Working logic */ }
        public void Eat() { /* Eating logic */ }
    }

    public class Slave : IWorkable
    {
        public void Work() { /* Working logic */ }
    }
}
