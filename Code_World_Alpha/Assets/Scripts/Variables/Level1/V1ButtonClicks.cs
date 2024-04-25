using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class V1ButtonClicks : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _errorSoundClip,_successSoundClip;
    [SerializeField]GameObject cover;
    [SerializeField]string sceneName;


public void buttonClickcorrect(){
    _source.PlayOneShot(_successSoundClip);
    cover.SetActive(true);
    StartCoroutine(LoadScene(sceneName));

   
}
public void buttonClickwrong(){
    
    _source.PlayOneShot(_errorSoundClip);
    
}
    IEnumerator LoadScene(string sceneName){
        yield return new WaitForSeconds(2f);
        FindObjectOfType<LevelLoader>().LoadNextLevel(sceneName);
            
         }
}
