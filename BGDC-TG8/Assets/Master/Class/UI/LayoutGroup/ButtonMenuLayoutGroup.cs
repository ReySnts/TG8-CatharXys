using UnityEngine;

[RequireComponent(requiredComponent: typeof(IFactory<IHaveType<ButtonType>>))]

public sealed class ButtonMenuLayoutGroup : LayoutGroupList<IHaveType<ButtonType>> { }