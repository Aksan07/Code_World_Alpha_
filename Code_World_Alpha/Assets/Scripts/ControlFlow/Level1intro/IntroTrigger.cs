using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroTrigger : MonoBehaviour
{
public IntroDialogue introDialogue;
private void TriggerDialogue(){
    FindObjectOfType<IntroDialogueManager>().StartDialogue(introDialogue);
    }
}
