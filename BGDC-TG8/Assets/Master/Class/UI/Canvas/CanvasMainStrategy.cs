using UnityEngine;

public sealed class CanvasMainStrategy : MonoBehaviour, IStrategy<ICanvasMenu>
{
    private ICanvasMenu iCanvasMenu;

    public void SetStrategy(ICanvasMenu iCanvasMenu)
    {
        this.iCanvasMenu = iCanvasMenu;
        SetActive();
    }

    private void SetActive() => Instantiate(original: iCanvasMenu.GameObject, parent: transform);
}