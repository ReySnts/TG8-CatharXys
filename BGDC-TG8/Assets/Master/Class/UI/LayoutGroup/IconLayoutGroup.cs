using UnityEngine;

[RequireComponent(requiredComponent: typeof(IFactory<ScriptableObjectBoss>))]

public sealed class IconLayoutGroup : LayoutGroupList<ScriptableObjectBoss> { }