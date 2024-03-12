using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    private bool dialogueTriggered = false;

    void Update()
    {
        // Check if the dialogue has not been triggered yet and the player clicked the mouse
        if (!dialogueTriggered && Input.GetMouseButtonDown(0))
        {
            TriggerDialogue();
            dialogueTriggered = true; // Mark dialogue as triggered to prevent multiple triggers
        }
    }
    public void TriggerDialogue(){
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
   

}
