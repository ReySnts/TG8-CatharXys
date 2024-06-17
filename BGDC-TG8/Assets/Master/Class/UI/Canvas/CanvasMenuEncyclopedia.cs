using UnityEngine;

public class CanvasMenuEncyclopedia : MonoBehaviour, ICanvasMenuEncyclopedia
{
    [field: SerializeField] public int Index { get; set; }

    public IListScriptableObjectBoss IListScriptableObjectBoss { get; private set; }

    private void Awake() => IListScriptableObjectBoss = GetComponent<IListScriptableObjectBoss>();
}