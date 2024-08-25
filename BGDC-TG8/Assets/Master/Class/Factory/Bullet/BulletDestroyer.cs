using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject basicBulletHit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(GameObjectTag.PLAYER))
        {
            Destroy(obj: Instantiate(original: basicBulletHit, position: transform.position, rotation: Quaternion.identity), t: 1f);
            Destroy(gameObject);
        }
    }
}