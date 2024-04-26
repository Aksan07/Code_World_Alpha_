
using UnityEngine;
using System;

public class LoadSceneButton : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _SoundClip;

    void onClick(){
        _source.PlayOneShot(_SoundClip);

    }
    
}
