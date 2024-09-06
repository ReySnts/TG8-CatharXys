public sealed class ButtonOptions : ButtonMenu
{
    public override ButtonType Type => ButtonType.Options;

    protected override MenuType MenuType => MenuType.Options;
}