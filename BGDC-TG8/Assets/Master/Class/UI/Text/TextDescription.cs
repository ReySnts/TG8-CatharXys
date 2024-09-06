public sealed class TextDescription : TextScript
{
    protected override void OnEnable()
    {
        base.OnEnable();
        tMP.text = selectedScriptableObjectBoss?.Description;
    }
}