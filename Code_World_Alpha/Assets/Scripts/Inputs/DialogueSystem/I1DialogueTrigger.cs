using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I1DialogueTrigger : MonoBehaviour
{

public V1Dialogue v1Dialogue;

[SerializeField]GameObject popups;
[SerializeField]bool isfirsttrigger=true;

public void Start()
{
    if(isfirsttrigger){
        TriggerDialogue();
    }
    }
private void TriggerDialogue(){
    FindObjectOfType<I1DialogueManager>().StartDialogue(v1Dialogue);
    }
    private void StartAnimation(){
        
        Debug.Log("Counted");
        popups.SetActive(true);
       popups.GetComponent<Animator>().enabled = true;
       
}}
