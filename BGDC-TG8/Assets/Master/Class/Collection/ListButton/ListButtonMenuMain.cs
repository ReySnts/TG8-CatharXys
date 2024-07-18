public class ListButtonMenuMain : ListScript<IButton>
{
    protected override void Awake()
    {
        list.Add(item: new ButtonPlay());
        list.Add(item: new ButtonLoad());
        list.Add(item: new ButtonOptions());
        list.Add(item: new ButtonEncyclopedia());
        list.Add(item: new ButtonQuit());
    }
}