using UnityEngine;

public class BulletProduct : MonoBehaviour, IProduct<Vector2>
{
    [SerializeField] private float moveSpeed;

    private Rigidbody2D rigidBody2D;

    private Vector2 targetPosition = Vector2.zero;

    public void Initialize(Vector2 mousePointerClickPosition)
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        targetPosition = mousePointerClickPosition - (Vector2)transform.position;
    }

    private void Update() => rigidBody2D.AddForce(force: targetPosition.normalized * moveSpeed);
}