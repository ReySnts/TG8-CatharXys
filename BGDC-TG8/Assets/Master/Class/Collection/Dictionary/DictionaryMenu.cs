using System.Linq;

public sealed class DictionaryMenu : DictionaryScript<MenuType, CanvasMenu>
{
    protected override void Awake()
    {
        var canvasMenus = GetComponentsInChildren<CanvasMenu>().ToList();
        canvasMenus.ForEach(action: canvasMenu => dictionary.Add(key: canvasMenu.Type, value: canvasMenu));
        canvasMenus.ForEach(action: canvasMenu => canvasMenu.gameObject.SetActive(value: false));
    }
}