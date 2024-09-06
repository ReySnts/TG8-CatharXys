public abstract class ButtonMenu : ButtonScript, IHaveType<ButtonType>
{
    public abstract ButtonType Type { get; }

    protected abstract MenuType MenuType { get; }

    private StateMachineScript<CanvasMenu, MenuType> menuStateMachine;

    protected override void OnEnable()
    {
        menuStateMachine = GetComponentInParent<StateMachineScript<CanvasMenu, MenuType>>();
        base.OnEnable();
    }

    protected override void OnClick() => menuStateMachine.TransitionTo(nextState: MenuType);
}