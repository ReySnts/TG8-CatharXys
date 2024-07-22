using UnityEngine.UI;

public sealed class ListButtonMenuMain : ListScript<IHaveType<ButtonType>>
{
    protected override void Awake()
    {
        list.Add(item: gameObject.AddComponent<ButtonPlay>());
        list.Add(item: gameObject.AddComponent<ButtonLoad>());
        list.Add(item: gameObject.AddComponent<ButtonOptions>());
        list.Add(item: gameObject.AddComponent<ButtonEncyclopedia>());
        list.Add(item: gameObject.AddComponent<ButtonQuit>());
        list.ForEach(action: item => Destroy(item as ButtonMenu));
        Destroy(obj: GetComponent<Button>());
    }
}