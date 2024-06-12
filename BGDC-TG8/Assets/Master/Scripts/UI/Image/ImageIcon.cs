using UnityEngine;
using UnityEngine.EventSystems;

public class ImageIcon : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private ICanvasMenuEncyclopedia iCanvasMenuEncyclopedia;

    private IIndexable iIndexable;

    private void Awake()
    {
        iCanvasMenuEncyclopedia = GetComponentInParent<ICanvasMenuEncyclopedia>();
        iIndexable = GetComponent<IIndexable>();
    }

    public void OnPointerEnter(PointerEventData eventData) => iCanvasMenuEncyclopedia.Index = iIndexable.Index;

    public void OnPointerExit(PointerEventData eventData) => iCanvasMenuEncyclopedia.Index = 0;
}