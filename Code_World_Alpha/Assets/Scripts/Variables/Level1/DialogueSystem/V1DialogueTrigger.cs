using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V1DialogueTrigger : MonoBehaviour
{
public V1Dialogue v1Dialogue;

[SerializeField]GameObject datatypes;

public void Start()
{
    // TriggerDialogue();
}
private void TriggerDialogue(){
    FindObjectOfType<V1DialogueManager>().StartDialogue(v1Dialogue);
    }
    private void StartAnimation(){
        
        Debug.Log("Counted");
       datatypes.GetComponent<Animator>().enabled = true;
       
    }
}
