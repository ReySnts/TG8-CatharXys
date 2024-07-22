using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public sealed class ImageDisplay : MonoBehaviour
{
    private void OnEnable() => GetComponent<Image>().sprite = GetComponentInParent<ScriptableObjectContainer<ScriptableObjectBoss>>().ScriptableObject?.DisplayImage;
}