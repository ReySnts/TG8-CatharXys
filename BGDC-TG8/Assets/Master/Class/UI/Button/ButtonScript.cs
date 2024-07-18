using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public abstract class ButtonScript : MonoBehaviour, IButton
{
    protected abstract ButtonType ButtonType { get; }

    public string Text => ButtonType.ToString();

    protected abstract void OnClick();

    private Button button;

    protected virtual void OnEnable ()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(OnClick);
        button = null;
    }
}