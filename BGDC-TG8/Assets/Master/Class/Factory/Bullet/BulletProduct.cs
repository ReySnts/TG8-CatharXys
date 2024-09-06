using UnityEngine;

public class BulletProduct : MonoBehaviour, IProduct<Vector2>
{
    [SerializeField] private float force = 22f;

    public void Initialize(Vector2 mousePointerClickPosition)
    {
        var rigidBody2D = GetComponent<Rigidbody2D>();
        var position = (Vector2)transform.position;
        var direction = mousePointerClickPosition - position;
        var rotation = position - mousePointerClickPosition;
        var rot2 = Mathf.Atan2(y: rotation.y, x: rotation.x) * Mathf.Rad2Deg;
        rigidBody2D.velocity = new Vector2(x: direction.x, y: direction.y).normalized * force;
        transform.rotation = Quaternion.Euler(x: 0f, y: 0f, z: rot2 + 90f);
    }
}