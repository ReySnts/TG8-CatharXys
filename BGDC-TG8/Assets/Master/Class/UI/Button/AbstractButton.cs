using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public abstract class AbstractButton : MonoBehaviour
{
    protected Button button;

    protected virtual void OnEnable()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(call: OnClick);
    }

    protected virtual void OnClick() { }

    private void OnDisable()
    {
        button.onClick.RemoveAllListeners();
        button = null;
    }
}