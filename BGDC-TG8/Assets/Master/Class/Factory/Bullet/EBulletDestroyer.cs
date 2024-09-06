using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBulletDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject basicBulletHit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(obj: Instantiate(original: basicBulletHit, position: transform.position, rotation: Quaternion.identity), t: 1f);
            Destroy(gameObject);
        }
    }
}
