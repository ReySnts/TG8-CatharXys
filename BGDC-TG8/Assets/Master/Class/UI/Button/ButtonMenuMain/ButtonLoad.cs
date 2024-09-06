public sealed class ButtonLoad : ButtonMenu
{
    public override ButtonType Type => ButtonType.Load;

    protected override MenuType MenuType => MenuType.SaveLoad;
}