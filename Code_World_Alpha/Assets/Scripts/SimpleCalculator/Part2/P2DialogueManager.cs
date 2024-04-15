using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class P2DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    // [SerializeField]private String sceneName;
    private Queue<string> sentences;
    private bool _startconvo=false;
    int count=0;
    //public Animator anim;

    void Start()
    {
        sentences = new Queue<string>();
        
    }

    public void StartDialogue(FDialogue fDialogue){
        Debug.Log("Starting Conversation with");
        //nameText.text=dialogue.name;
        sentences.Clear();

        foreach (string sentence in fDialogue.sentences){
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
        // GoToScene(sceneName);
        count++;
        //anim.SetBool("IsOutro", true);
        
    }
    // public void GoToScene(string sceneName){
    //    StartCoroutine(LoadAsynchronously(sceneName));
    // }
    // IEnumerator LoadAsynchronously(string sceneName){
    //      AsyncOperation operations =SceneManager.LoadSceneAsync(sceneName);
    //         yield return null;
    //      }
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
