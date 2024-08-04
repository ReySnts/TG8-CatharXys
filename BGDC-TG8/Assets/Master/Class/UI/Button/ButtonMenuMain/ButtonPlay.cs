public sealed class ButtonPlay : AbstractButton, IHaveType<ButtonType>
{
    public ButtonType Type => ButtonType.Play;
}