using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PuzzleSlot : MonoBehaviour
{
    // Animator component reference for the slot
    public Animator slotAnimator;


    // Event called when a puzzle piece is placed in the slot
    public void OnPiecePlaced()
    {
        // Activate the Animator component
        if (slotAnimator != null)
            slotAnimator.enabled = true;
           



        
    }


}
