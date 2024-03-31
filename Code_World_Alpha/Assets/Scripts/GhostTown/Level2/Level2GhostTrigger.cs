using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2GhostTrigger : MonoBehaviour
{
    // Start is called before the first frame update
public GhostDialogue ghostDialogue;
private void TriggerDialogue(){
    FindObjectOfType<Level2GhostManager>().StartDialogue(ghostDialogue);
    }
}
