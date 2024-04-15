using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicks : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _errorSoundClip,_successSoundClip;
public void buttonClickcorrect(){
    Debug.Log("button has been clicked");
    _source.PlayOneShot(_successSoundClip);
}
public void buttonClickwrong(){
    Debug.Log("wrong");
    _source.PlayOneShot(_successSoundClip);
}
}
