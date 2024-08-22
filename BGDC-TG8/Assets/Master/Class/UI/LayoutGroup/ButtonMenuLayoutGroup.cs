using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractFactory<IHaveType<ButtonType>>))]

public sealed class ButtonMenuLayoutGroup : LayoutGroupList<IHaveType<ButtonType>> { }