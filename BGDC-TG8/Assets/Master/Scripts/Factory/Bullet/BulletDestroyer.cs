using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag(GameObjectTag.PLAYER)) Destroy(gameObject);
    }
}