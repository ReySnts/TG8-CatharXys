public sealed class TextName : AbstractText
{
    protected override void OnEnable()
    {
        base.OnEnable();
        tMP.text = selectedScriptableObjectBoss?.Name;
    }
}