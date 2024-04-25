using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IPuzzleManager : MonoBehaviour
{
    public int totalPuzzlePieces = 2; // Set the total number of puzzle pieces here
    private int placedPuzzlePieces = 0;
    [SerializeField]GameObject coverImage;
    [SerializeField]string sceneName;

    public void PiecePlaced()
    {
        placedPuzzlePieces++;

        if (placedPuzzlePieces >= totalPuzzlePieces)
        {
            Debug.Log("Puzzles Completed");
            coverImage.GetComponent<Animator>().enabled = true;
            StartCoroutine(LoadScene(sceneName));
        }
        IEnumerator LoadScene(string sceneName){
        yield return new WaitForSeconds(2f);
        FindObjectOfType<LevelLoader>().LoadNextLevel(sceneName);
            
         }
    }}
