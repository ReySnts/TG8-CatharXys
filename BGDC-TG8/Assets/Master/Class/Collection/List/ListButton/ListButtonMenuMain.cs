using UnityEngine.UI;

public sealed class ListButtonMenuMain : AbstractList<IHaveType<ButtonType>>
{
    protected override void Awake()
    {
        list.Add(item: gameObject.AddComponent<ButtonPlay>());
        list.Add(item: gameObject.AddComponent<ButtonLoad>());
        list.Add(item: gameObject.AddComponent<ButtonOptions>());
        list.Add(item: gameObject.AddComponent<ButtonEncyclopedia>());
        list.Add(item: gameObject.AddComponent<ButtonQuit>());
        list.ForEach(action: item => Destroy(item as AbstractButton));
        Destroy(obj: GetComponent<Button>());
    }
}