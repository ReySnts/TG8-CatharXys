public sealed class ButtonQuit : AbstractButton, IHaveType<ButtonType>
{
    public ButtonType Type => ButtonType.Quit;
}