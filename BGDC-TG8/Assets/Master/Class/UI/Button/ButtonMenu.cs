public abstract class ButtonMenu : ButtonScript, IHaveType<ButtonType>
{
    public abstract ButtonType Type { get; }

    protected StateMachineScript<CanvasMenu, MenuType> menuStateMachine;

    protected override void OnEnable()
    {
        menuStateMachine = GetComponentInParent<StateMachineScript<CanvasMenu, MenuType>>();
        base.OnEnable();
    }
}