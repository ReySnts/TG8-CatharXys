using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BEBulletDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject VortexSpawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(obj: Instantiate(original: VortexSpawn, position: transform.position, rotation: Quaternion.identity), t: 10f);
            Destroy(gameObject);
        }
    }
}

