namespace Decorator.DecoratorPattern
{
    public class Decorator : IComponent
    {
        protected IComponent _component;

        public Decorator(IComponent component)
        {
            this._component = component;
        }
        
        public void SetComponent(IComponent component)
        {
            this._component = component;
        }

        // The Decorator delegates all work to the wrapped component.
        public virtual string Operation()
        {
            if (this._component != null)
            {
                return this._component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}