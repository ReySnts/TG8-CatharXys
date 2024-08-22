using TMPro;

public class ButtonMenuProduct : AbstractProduct<IHaveType<ButtonType>>
{
    public override void Initialize(IHaveType<ButtonType> buttonMenu)
    {
        gameObject.AddComponent(componentType: buttonMenu.GetType());
        GetComponentInChildren<TextMeshProUGUI>().text = buttonMenu.Type.ToString();
    }
}