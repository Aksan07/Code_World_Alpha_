using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateDialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
public PirateDialogue pirateDialogue;
public void TriggerDialogue(){
    FindObjectOfType<PirateDialogueManager>().StartDialogue(pirateDialogue);
    }
}
