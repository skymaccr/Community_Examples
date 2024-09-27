
/// <summary>
/// D Dependency Inversion Principle (DIP)
/// Definition: High-level modules should not depend on low-level modules. Both should depend on abstractions. Abstractions should not depend on details. Details should depend on abstractions.
/// </summary>
namespace SOLID.Principles.D
{
    public class LightBulb_Wrong
    {
        public void TurnOn()
        {
            Console.WriteLine(" Turn on logic");
        }
    }

    public class Switch_Wrong
    {
        private LightBulb_Wrong _lightBulb;

        public Switch_Wrong()
        {
            _lightBulb = new LightBulb_Wrong();
        }

        public void Operate()
        {
            _lightBulb.TurnOn();
        }
    }

    public interface ILight
    {
        void TurnOn();
    }

    public class LightBulb : ILight
    {
        public void TurnOn()
        {
            Console.WriteLine(" Turn on logic");
        }
    }

    public class Switch
    {
        private ILight _light;

        public Switch(ILight light)
        {
            _light = light;
        }

        public void Operate()
        {
            _light.TurnOn();
        }
    }

}
