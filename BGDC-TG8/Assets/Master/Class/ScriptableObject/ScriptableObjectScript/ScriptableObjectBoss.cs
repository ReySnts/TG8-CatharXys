using UnityEngine;

[CreateAssetMenu(fileName = FileName.BOSS, menuName = FilePath.BOSS)]

public sealed class ScriptableObjectBoss : ScriptableObjectScript, IScriptableObjectBoss
{
    [field: SerializeField, Space(height: 10f)] public string Name { get; private set; }

    [field: SerializeField, Space(height: 10f), TextArea(minLines: 1, maxLines: 20)] public string Description { get; private set; }

    [field: SerializeField, Space(height: 10f)] public Sprite IconImage { get; private set; }

    [field: SerializeField, Space(height: 10f)] public Sprite DisplayImage { get; private set; }
}