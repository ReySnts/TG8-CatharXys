public sealed class ButtonEncyclopedia : ButtonMenu
{
    public override ButtonType Type => ButtonType.Encyclopedia;

    protected override void OnClick() => menuStateMachine.TransitionTo(nextState: MenuType.Encyclopedia);
}