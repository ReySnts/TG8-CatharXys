using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractFactory<ScriptableObjectBoss>))]

public sealed class IconLayoutGroup : LayoutGroupList<ScriptableObjectBoss> { }