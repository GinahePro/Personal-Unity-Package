namespace DesignPatter.BaseStateMachine
{
    public interface IState 
    {
        public StateMachine StateMachine { get; set; }
        public void OnEnter();
        public void OnLeave();

        public void CustomUpdate();
    }
}
