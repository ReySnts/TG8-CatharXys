using UnityEngine;

public class CanvasDetailBoss : MonoBehaviour, ICanvasDetailBoss
{
    public IScriptableObjectBoss IScriptableObjectBoss { get; private set; }

    private ICanvasMenuEncyclopedia iCanvasMenuEncyclopedia;

    private void Awake() => iCanvasMenuEncyclopedia = GetComponentInParent<ICanvasMenuEncyclopedia>();

    private void Update() => IScriptableObjectBoss = iCanvasMenuEncyclopedia.IListScriptableObjectBoss.List[iCanvasMenuEncyclopedia.Index];
}