using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotAnimationTrigger : MonoBehaviour
{

public GameObject outroObject; // Reference to the game object with the outro animation

    // Event called when a puzzle piece is placed in the slot
    public void OnPiecePlaced()
    {
        // Trigger the outro animation
        if (outroObject != null)
        {
            Animator outroAnimator = outroObject.GetComponent<Animator>();
            if (outroAnimator != null)
            {
                outroAnimator.SetBool("IsOutro", true);
            }
            else
            {
                Debug.LogWarning("Animator component not found on outro object.");
            }
        }
        else
        {
            Debug.LogWarning("Outro object reference not set.");
        }
    }
}
