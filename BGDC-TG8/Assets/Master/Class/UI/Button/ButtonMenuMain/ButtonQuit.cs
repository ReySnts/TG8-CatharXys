public sealed class ButtonQuit : ButtonScript, IHaveType<ButtonType>
{
    public ButtonType Type => ButtonType.Quit;
}