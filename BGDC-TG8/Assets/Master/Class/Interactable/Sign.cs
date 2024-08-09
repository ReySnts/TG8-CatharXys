using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour, IInteractable
{

    bool playerInArea = false;

    public GameEvent onPlayerNearInteractable;

    public void Interact()
    {
        Debug.Log("Hello!");
    }

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerInArea = true;
        onPlayerNearInteractable.Raise(this, playerInArea);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerInArea = false;
        onPlayerNearInteractable.Raise(this, playerInArea);
    }

    private void Update()
    {
        if (playerInArea)
        {

        }
    }
}
