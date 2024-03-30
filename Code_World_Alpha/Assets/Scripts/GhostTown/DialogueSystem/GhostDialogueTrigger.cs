using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostDialogueTrigger : MonoBehaviour
{
public GhostDialogue ghostDialogue;
private void TriggerDialogue(){
    FindObjectOfType<GhostDialogueManager>().StartDialogue(ghostDialogue);
    }
}
