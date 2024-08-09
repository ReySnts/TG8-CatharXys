using UnityEngine;

public sealed class InputManager : MonoBehaviour
{
    public float AxisRawHorizontal => Input.GetAxisRaw(axisName: InputAxisName.HORIZONTAL);

    public float AxisRawVertical => Input.GetAxisRaw(axisName: InputAxisName.VERTICAL);

    public bool KeyDownLeftShift => Input.GetKeyDown(key: KeyCode.LeftShift);

    public bool MouseButtonDownLeft => Input.GetMouseButtonDown(button: 0);

    public Vector3 MousePosition => Input.mousePosition;
}