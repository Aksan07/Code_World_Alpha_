using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class F2PuzzleManager : MonoBehaviour
{
    
    [SerializeField]private String sceneName;
    public int totalPuzzlePieces = 2; // Set the total number of puzzle pieces here
    private int placedPuzzlePieces = 0;
    
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _victorySoundClip;
    [SerializeField] private float _waitingTime;


    public void PiecePlaced()
    {
        placedPuzzlePieces++;

        if (placedPuzzlePieces >= totalPuzzlePieces)
        {
            Debug.Log("Puzzles Completed");
            StartCoroutine(puzzleComplete());

            //instructions.enabled=false;
           // LevelComplete();
        }
    }
            public void GoToScene(string sceneName){
       StartCoroutine(LoadAsynchronously(sceneName));
    }
    IEnumerator LoadAsynchronously(string sceneName){
         AsyncOperation operations =SceneManager.LoadSceneAsync(sceneName);
            yield return null;
}
IEnumerator puzzleComplete(){
    
    _source.PlayOneShot(_victorySoundClip);
    yield return new WaitForSeconds(_waitingTime);
    GoToScene(sceneName);

}
}
