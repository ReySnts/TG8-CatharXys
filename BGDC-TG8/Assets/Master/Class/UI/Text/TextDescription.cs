public sealed class TextDescription : AbstractText
{
    protected override void OnEnable()
    {
        base.OnEnable();
        tMP.text = selectedScriptableObjectBoss?.Description;
    }
}