using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(IScriptableObjectBossContainer))]

public sealed class ImageIcon : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private IScriptableObjectBossContainer canvasMenuEncyclopedia;

    private IScriptableObjectBossContainer iScriptableObjectBossContainer;

    private ISwitchable iSwitchable;

    private void Awake()
    {
        canvasMenuEncyclopedia = transform.parent.GetComponentInParent<IScriptableObjectBossContainer>();
        iScriptableObjectBossContainer = GetComponent<IScriptableObjectBossContainer>();
        iSwitchable = GetComponentInParent<ISwitchable>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        iSwitchable.IsActive = true;
        canvasMenuEncyclopedia.IScriptableObject = iScriptableObjectBossContainer.IScriptableObject;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        canvasMenuEncyclopedia.IScriptableObject = null;
        iSwitchable.IsActive = false;
    }
}