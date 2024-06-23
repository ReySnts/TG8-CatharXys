using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject basicBulletHit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag(GameObjectTag.PLAYER))
        {
            Destroy(obj: Instantiate(original: basicBulletHit, position: transform.position, rotation: Quaternion.identity), t: 1f);
            Destroy(gameObject);
        }
    }
}