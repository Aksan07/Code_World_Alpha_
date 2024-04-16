using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class P3ButtonClicks : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _errorSoundClip,_successSoundClip;
    // [SerializeField] GameObject printobj,buttonobj,correctbutton;
    [SerializeField]Text instruction;
    // Start is called before the first frame update
public void buttonClickcorrect(){
    Debug.Log("button has been clicked");
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
    instruction.text="OK!!Let's check for any more errors";
    
}
IEnumerator wrongtext(){
    instruction.text="oohh... i don't think that is wrong";
    yield return new WaitForSeconds(2f);
    instruction.text="let's check again";
    
}
}
