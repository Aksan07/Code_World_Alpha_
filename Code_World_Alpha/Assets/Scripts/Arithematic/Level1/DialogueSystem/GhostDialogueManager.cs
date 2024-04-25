using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GhostDialogueManager : MonoBehaviour
{
    public Text dialogueText;
    private Queue<string> sentences;
    private bool _startconvo=false;
  
    void Start()
    {
        sentences = new Queue<string>();
        
    }

    public void StartDialogue(GhostDialogue ghostDialogue){
        Debug.Log("Starting Conversation with");
        //nameText.text=dialogue.name;
        sentences.Clear();

        foreach (string sentence in ghostDialogue.sentences){
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
        _startconvo=true;


    }
    public void DisplayNextSentence(){
        if (sentences.Count==0){
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text=sentence;
    }

    void EndDialogue(){
        //loadScene.GoToScene(levelname);
        Debug.Log("End of Conversation");
        
      
        
    }
        void Update()
    {
        // Check for mouse click
        if (_startconvo&&Input.GetMouseButtonDown(0))
        {
            // Call DisplayNextSentence() when mouse button is clicked
            DisplayNextSentence();
        }
    }
}



