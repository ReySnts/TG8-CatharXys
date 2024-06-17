using UnityEngine;
using UnityEngine.UI;

public class ImageDisplay : MonoBehaviour
{
    private ICanvasDetailBoss iCanvasDetailBoss;

    private Image image;

    private void Awake()
    {
        iCanvasDetailBoss = GetComponentInParent<ICanvasDetailBoss>();
        image = GetComponent<Image>();
    }

    private void Update() => image.sprite = iCanvasDetailBoss?.IScriptableObjectBoss?.DisplayImage;
}