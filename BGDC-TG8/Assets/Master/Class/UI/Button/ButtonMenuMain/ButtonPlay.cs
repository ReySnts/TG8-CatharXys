public sealed class ButtonPlay : ButtonScript, IHaveType<ButtonType>
{
    public ButtonType Type => ButtonType.Play;
}