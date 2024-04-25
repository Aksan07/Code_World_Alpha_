using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class FPuzzleManager : MonoBehaviour
{
    
    [SerializeField]private String sceneName;
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _victorySoundClip;
    [SerializeField] private float _waitingTime;
public int totalPuzzlePieces = 2; // Set the total number of puzzle pieces here
    private int placedPuzzlePieces = 0;

    public void PiecePlaced()
    {
        placedPuzzlePieces++;

        if (placedPuzzlePieces >= totalPuzzlePieces)
        {
            Debug.Log("Puzzles Completed");
            StartCoroutine(PuzzleComplete());
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
IEnumerator PuzzleComplete(){
    
    _source.PlayOneShot(_victorySoundClip);
    yield return new WaitForSeconds(_waitingTime);

}
}
