using UnityEngine;
using UnityEngine.UI;

[RequireComponent(requiredComponent: typeof(Image), requiredComponent2: typeof(ScriptableObjectContainer<ScriptableObjectBoss>))]

public sealed class BossIconProduct : AbstractProduct<ScriptableObjectBoss>
{
    public override void Initialize(ScriptableObjectBoss scriptableObjectBoss)
    {
        GetComponent<Image>().sprite = scriptableObjectBoss.IconImage;
        GetComponent<ScriptableObjectContainer<ScriptableObjectBoss>>().ScriptableObject = scriptableObjectBoss;
    }
}