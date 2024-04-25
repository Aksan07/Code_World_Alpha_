using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class P3PuzzleManager : MonoBehaviour
{
[SerializeField] int totalPuzzlePieces; // Set the total number of puzzle pieces here
    private int solvedPuzzlePieces = 0;
    [SerializeField]Text dialogue;
    [SerializeField] string sceneName;
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _successSoundClip;

    public void PieceSolved()
    {
        solvedPuzzlePieces++;

        if (solvedPuzzlePieces >= totalPuzzlePieces)
        {
            dialogue.enabled=false;
           _source.PlayOneShot(_successSoundClip);
           GoToScene(sceneName);
        }
    }
    public void GoToScene(string sceneName){
       StartCoroutine(LoadAsynchronously(sceneName));
    }
    IEnumerator LoadAsynchronously(string sceneName){
        yield return new WaitForSeconds(2f);
        FindObjectOfType<LevelLoader>().LoadNextLevel(sceneName);
         }
}
