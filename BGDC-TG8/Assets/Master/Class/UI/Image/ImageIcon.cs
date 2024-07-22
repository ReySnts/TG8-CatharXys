using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(requiredComponent: typeof(ScriptableObjectContainer<ScriptableObjectBoss>))]

public sealed class ImageIcon : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private ScriptableObjectContainer<ScriptableObjectBoss> canvasMenuEncyclopedia;

    private ScriptableObjectContainer<ScriptableObjectBoss> iScriptableObjectBossContainer;

    private ISwitchable iSwitchable;

    private void Awake()
    {
        canvasMenuEncyclopedia = transform.parent.GetComponentInParent<ScriptableObjectContainer<ScriptableObjectBoss>>();
        iScriptableObjectBossContainer = GetComponent<ScriptableObjectContainer<ScriptableObjectBoss>>();
        iSwitchable = GetComponentInParent<ISwitchable>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        iSwitchable.IsActive = true;
        canvasMenuEncyclopedia.ScriptableObject = iScriptableObjectBossContainer.ScriptableObject;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        canvasMenuEncyclopedia.ScriptableObject = null;
        iSwitchable.IsActive = false;
    }
}