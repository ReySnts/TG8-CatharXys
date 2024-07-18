using TMPro;
using UnityEngine;

public class ButtonProduct : MonoBehaviour, IProduct<IButton>
{
    public void Initialize(IButton iButton)
    {
        gameObject.AddComponent(iButton.GetType());
        GetComponentInChildren<TextMeshProUGUI>().text = iButton.Text;
    }
}