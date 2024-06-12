using UnityEngine;

public class CanvasMenuEncyclopedia : MonoBehaviour, ICanvasMenuEncyclopedia
{
    [field: SerializeField] public int Index { get; set; }

    public IListScriptableObjectBoss ListScriptableObjectBoss { get; private set; }

    private void Awake() => ListScriptableObjectBoss = GetComponent<IListScriptableObjectBoss>();
}