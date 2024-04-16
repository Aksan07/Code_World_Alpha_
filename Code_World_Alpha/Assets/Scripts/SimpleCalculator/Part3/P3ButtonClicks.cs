using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class P3ButtonClicks : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _errorSoundClip,_successSoundClip;
    [SerializeField] GameObject animobj;
    [SerializeField]Text instruction;
    [SerializeField] GameObject anim;
    private P3PuzzleManager p3puzzleManager;
    
    // Start is called before the first frame update
    void Awake()
    {
        p3puzzleManager = FindObjectOfType<P3PuzzleManager>();
        
    }
public void buttonClickcorrect(){
    p3puzzleManager.PieceSolved();
    anim.GetComponent<Animator>().enabled = true;
    _source.PlayOneShot(_successSoundClip);
    StartCoroutine(righttext());
}
public void buttonClickwrong(){
    Debug.Log("wrong");
    _source.PlayOneShot(_errorSoundClip);
    StartCoroutine(wrongtext());
}
IEnumerator righttext(){
    instruction.text="YES!!Now i remember";
    yield return new WaitForSeconds(2f);
    Destroy(gameObject);
    animobj.GetComponent<Animator>().enabled=true;
    instruction.text="OK!!Let's check for any more errors";
    
}
IEnumerator wrongtext(){
    instruction.text="oohh... i don't think that is wrong";
    yield return new WaitForSeconds(2f);
    instruction.text="let's check again";
    
}
}
