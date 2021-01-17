namespace Decorator.DecoratorPattern
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    public class ConcreteComponent : IComponent
    {
        public string Operation()
        {
            return "ConcreteComponent";
        }
    }
}