using UnityEngine;

[RequireComponent(requiredComponent: typeof(Rigidbody2D))]

public sealed class BulletProduct : MonoBehaviour, IProduct<Vector2>
{
    [SerializeField] private float force = 22f;

    public void Initialize(Vector2 mousePointerClickPosition)
    {
        var direction = (mousePointerClickPosition - (Vector2)transform.position).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * force;
    }
}