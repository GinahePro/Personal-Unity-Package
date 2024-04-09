namespace DesignPatter.BaseStateMachine
{
    public abstract class State<T> : IState where T : StateContext
    {
        protected T _context;
        public StateMachine StateMachine { get; set ; }

        public State(T context)
        {
            _context = context;
        }
        public abstract void OnEnter();

        public abstract void OnLeave();

        public abstract void CustomUpdate();
    }
}
