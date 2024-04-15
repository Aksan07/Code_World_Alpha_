using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part1DialogueTrigger : MonoBehaviour
{
public FDialogue fDialogue;


private void TriggerDialogue(){
    FindObjectOfType<FDialogueManager>().StartDialogue(fDialogue);
    }
}
