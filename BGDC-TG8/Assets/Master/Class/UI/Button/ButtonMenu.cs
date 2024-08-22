public abstract class ButtonMenu : AbstractButton, IHaveType<ButtonType>
{
    public abstract ButtonType Type { get; }

    protected abstract MenuType MenuType { get; }

    private AbstractStateMachine<CanvasMenu, MenuType> menuStateMachine;

    protected override void OnEnable()
    {
        menuStateMachine = GetComponentInParent<AbstractStateMachine<CanvasMenu, MenuType>>();
        base.OnEnable();
    }

    protected override void OnClick() => menuStateMachine.TransitionTo(nextState: MenuType);
}