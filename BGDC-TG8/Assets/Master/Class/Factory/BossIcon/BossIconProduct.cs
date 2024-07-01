using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image), typeof(IScriptableObjectBoss))]

public sealed class BossIconProduct : MonoBehaviour, IProduct<IScriptableObjectBoss>
{
    public void Initialize(IScriptableObjectBoss iScriptableObjectBoss)
    {
        GetComponent<Image>().sprite = iScriptableObjectBoss.IconImage;
        GetComponent<IScriptableObjectBossContainer>().IScriptableObject = iScriptableObjectBoss as ScriptableObjectBoss;
    }
}