public class ButtonEncyclopedia : ButtonScript
{
    protected override ButtonType ButtonType => ButtonType.Encyclopedia;

    private IStrategy<ICanvasMenu> iStrategy;

    protected override void OnEnable()
    {
        iStrategy = GetComponentInParent<IStrategy<ICanvasMenu>>();
        base.OnEnable();
    }

    protected override void OnClick() => iStrategy.SetStrategy(strategy: new CanvasMenuEncyclopedia());
}