using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FDialogueTrigger : MonoBehaviour
{
public FDialogue fDialogue;

public void Start()
{
    TriggerDialogue();
}
private void TriggerDialogue(){
    FindObjectOfType<FDialogueManager>().StartDialogue(fDialogue);
    }
}

