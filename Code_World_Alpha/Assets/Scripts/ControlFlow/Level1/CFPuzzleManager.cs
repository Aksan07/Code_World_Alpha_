using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CFPuzzleManager : MonoBehaviour
{
  public int totalPuzzlePieces = 2; // Set the total number of puzzle pieces here
    private int placedPuzzlePieces = 0;
 
    [SerializeField]private String sceneName;
    



    public void PiecePlaced()
    {
        placedPuzzlePieces++;

        if (placedPuzzlePieces >= totalPuzzlePieces)
        {
            Debug.Log("Puzzles Completed");
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
}
