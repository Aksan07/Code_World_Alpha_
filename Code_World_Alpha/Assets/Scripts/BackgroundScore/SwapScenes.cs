using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SwapScenes : MonoBehaviour
{
    [SerializeField]string levelname;
    [SerializeField] AudioClip audioClip;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
 
        if (SceneManager.GetActiveScene().name == levelname)
            BGmusic.instance.GetComponent<AudioSource>().Pause();
            BGmusic.instance.GetComponent<AudioSource>().PlayOneShot(audioClip);
 
    }
}