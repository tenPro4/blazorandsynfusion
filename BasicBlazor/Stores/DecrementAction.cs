namespace BasicBlazor.Stores
{
    public class DecrementAction:IAction
    {
        public const string DECREMENT = "DECREMENT";

        public string Name => DECREMENT;
    }
}
