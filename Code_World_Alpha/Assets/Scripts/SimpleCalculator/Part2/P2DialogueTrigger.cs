using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2DialogueTrigger : MonoBehaviour
{
public FDialogue fDialogue;

public void Start()
{
    TriggerDialogue();
}
private void TriggerDialogue(){
    FindObjectOfType<P2DialogueManager>().StartDialogue(fDialogue);
    }
}
