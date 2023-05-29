using System.Threading.Tasks.Dataflow;

namespace BasicBlazor.Stores
{
    public class CounterState
    {
        public int Count { get; set; }

        public CounterState(int count)
        {
            Count = count;
        }
    }

    public class CounterStore
    {
        private CounterState _state;
        private readonly IActionDispatcher actionDispatcher;

        public CounterStore(IActionDispatcher actionDispatcher)
        {
            _state= new CounterState(0);
            this.actionDispatcher = actionDispatcher;
            this.actionDispatcher.Subscript(HandleAction);
        }

        public CounterState GetState()
        {
            return _state;
        }

        public void HandleAction(IAction action)
        {
            switch(action.Name)
            {
                case IncrementAction.INCREMENT:
                    IncrementCount();
                    break;
                case DecrementAction.DECREMENT:
                    DecrementCounter();
                    break;
                default:break;
            }
        }

        public void IncrementCount()
        {
            var count = this._state.Count;
            count++;
            this._state = new CounterState(count);
            BoardCastStateChange();
        }

        public void DecrementCounter()
        {
            var count = this._state.Count;
            count--;
            this._state = new CounterState(count);
            BoardCastStateChange();
        }

        private Action _listeners;

        public void AddStateChangeListeners(Action listener)
        {
            _listeners += listener;
        }

        public void RemoveStateChangeListeners(Action listener)
        {
            _listeners -= listener;
        }

        public void BoardCastStateChange()
        {
            _listeners.Invoke();
        }
    }
}
