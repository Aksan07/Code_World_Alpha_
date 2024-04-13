using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroDialogueManager : MonoBehaviour
{

    public Text dialogueText;
    private Queue<string> sentences;
    private bool _startconvo=false;
    int count=0;
    //public Animator anim;

    void Start()
    {
        sentences = new Queue<string>();
        
    }

    public void StartDialogue(IntroDialogue introDialogue){
        Debug.Log("Starting Conversation with");
        //nameText.text=dialogue.name;
        sentences.Clear();

        foreach (string sentence in introDialogue.sentences){
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
        count++;
        //anim.SetBool("IsOutro", true);
        
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
