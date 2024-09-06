using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float zoomSpeed = 5f;
    public float minZoom = 5f;
    public float maxZoom = 20f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);

        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        Camera.main.orthographicSize -= scrollInput * zoomSpeed;
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minZoom, maxZoom);
    }
}
