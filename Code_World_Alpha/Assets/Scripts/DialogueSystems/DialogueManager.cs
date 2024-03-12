using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
   // public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    public LoadSceneButton loadScene;
    public string levelname;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        
    }

    public void StartDialogue(Dialogue dialogue){
        Debug.Log("Starting Conversation with"+ dialogue.name);
        //nameText.text=dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();

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
        loadScene.GoToScene(levelname);
        Debug.Log("End of Conversation");
    }



}