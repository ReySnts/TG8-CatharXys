using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]

public abstract class TextScript : MonoBehaviour
{
    protected TextMeshProUGUI tMP;

    protected ScriptableObjectBoss selectedScriptableObjectBoss;

    protected virtual void OnEnable()
    {
        tMP = GetComponent<TextMeshProUGUI>();
        selectedScriptableObjectBoss = GetComponentInParent<IScriptableObjectBossContainer>().IScriptableObject;
    }
}