namespace BasicBlazor.Stores
{
    public interface IActionDispatcher
    {
        void Dispatch(IAction action);
        void Subscript(Action<IAction> registerdActionHandlers);
        void UnSubscript(Action<IAction> actionHandler);
    }
}