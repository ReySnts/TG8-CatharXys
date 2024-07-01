using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public sealed class ImageDisplay : MonoBehaviour
{
    private void OnEnable() => GetComponent<Image>().sprite = GetComponentInParent<IScriptableObjectBossContainer>().IScriptableObject?.DisplayImage;
}