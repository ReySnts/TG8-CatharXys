using UnityEngine;

public sealed class InputManager : MonoBehaviour
{
    public float AxisRawHorizontal => Input.GetAxisRaw(InputAxisName.HORIZONTAL);

    public float AxisRawVertical => Input.GetAxisRaw(InputAxisName.VERTICAL);

    public bool LeftMouseButtonDown => Input.GetMouseButtonDown(button: 0);

    public Vector3 MousePosition => Input.mousePosition;
}