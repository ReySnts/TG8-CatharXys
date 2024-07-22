public sealed class TextName : TextScript
{
    protected override void OnEnable()
    {
        base.OnEnable();
        tMP.text = selectedScriptableObjectBoss?.Name;
    }
}