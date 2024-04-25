using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;
public class I1DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update    public Text dialogueText;
    [SerializeField]private string sceneName;
    [SerializeField]GameObject dialoguebox;
     public Text dialogueText;
    private Queue<string> sentences;
    private bool _startconvo=false;
    private I1DialogueTrigger i1DialogueTrigger;
    [SerializeField]bool isIntro;
    private bool islevelOver=false;
    [SerializeField]GameObject inputtextbox;
    [SerializeField]GameObject printtextbox;
    //public Animator anim;

    void Start()
    {
        sentences = new Queue<string>();
        
    }

    public void StartDialogue(V1Dialogue v1Dialogue){
        Debug.Log("Starting Conversation with");
        //nameText.text=dialogue.name;
        sentences.Clear();

        foreach (string sentence in v1Dialogue.sentences){
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
        if (dialogueText.text=="The input function"){
            Debug.Log("pop input");
            printtextbox.GetComponent<Animator>().SetBool("Istimetochange",true);
            inputtextbox.GetComponent<Animator>().enabled=true;

        }
        if (dialogueText.text=="It is pretty simple"){
            Debug.Log("pop input");
            inputtextbox.GetComponent<Animator>().enabled=true;
        }
    }

    void EndDialogue(){
        if (isIntro && islevelOver==false){
        //loadScene.GoToScene(levelname);
        Debug.Log("End of Conversation");
        dialoguebox.GetComponent<Animator>().enabled=true;
        islevelOver=true;
        }
        else if(isIntro&&islevelOver){
            FindObjectOfType<LevelLoader>().LoadNextLevel(sceneName);
        }
        else{
            FindObjectOfType<LevelLoader>().LoadNextLevel(sceneName);
        }
    
        
    }
    public void GoToScene(string sceneName){
       StartCoroutine(LoadAsynchronously(sceneName));
    }
    IEnumerator LoadAsynchronously(string sceneName){
         AsyncOperation operations =SceneManager.LoadSceneAsync(sceneName);
            yield return null;
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
