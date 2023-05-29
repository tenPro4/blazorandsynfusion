namespace BasicBlazor.Stores
{
    public class ActionDispatcher : IActionDispatcher
    {
        private Action<IAction> _registerdActionHandlers;

        public void Subscript(Action<IAction> registerdActionHandlers)
        {
            _registerdActionHandlers += registerdActionHandlers;
        }

        public void UnSubscript(Action<IAction> actionHandler)
        {
            _registerdActionHandlers -= actionHandler;
        }

        public void Dispatch(IAction action)
        {
            _registerdActionHandlers?.Invoke(action);
        }
    }
}
