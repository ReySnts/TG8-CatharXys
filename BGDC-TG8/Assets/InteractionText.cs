using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionText : MonoBehaviour
{
    public TextMeshPro text;
    public void interactionHint(Component sender, object data)
    {
        bool playerIsNear = (bool)data;

        if (playerIsNear) revealText();
        else hideText();

    }

    private void revealText()
    {
        text.enabled = true;
    }

    private void hideText()
    {
        text.enabled = false;
    }
}
