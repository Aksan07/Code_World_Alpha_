using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class V1ButtonClicks : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _errorSoundClip,_successSoundClip;
    [SerializeField]GameObject cover;


public void buttonClickcorrect(){
    _source.PlayOneShot(_successSoundClip);
    cover.SetActive(true);
   
}
public void buttonClickwrong(){
    
    _source.PlayOneShot(_errorSoundClip);
    
}

}
