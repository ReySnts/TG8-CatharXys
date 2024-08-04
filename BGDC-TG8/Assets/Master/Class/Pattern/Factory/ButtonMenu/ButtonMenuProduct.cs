using TMPro;
using UnityEngine;

public class ButtonMenuProduct : MonoBehaviour, IProduct<IHaveType<ButtonType>>
{
    public void Initialize(IHaveType<ButtonType> buttonMenu)
    {
        gameObject.AddComponent(componentType: buttonMenu.GetType());
        GetComponentInChildren<TextMeshProUGUI>().text = buttonMenu.Type.ToString();
    }
}