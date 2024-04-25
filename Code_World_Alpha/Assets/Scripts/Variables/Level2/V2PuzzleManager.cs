using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V2PuzzleManager : MonoBehaviour
{
    [SerializeField] int totalPuzzlePieces = 2; // Set the total number of puzzle pieces here
    private int deletedPuzzlePieces = 0;
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _successSoundClip;
    [SerializeField]string sceneName;


    public void PieceDeleted()
    {
        deletedPuzzlePieces++;

        if (deletedPuzzlePieces >= totalPuzzlePieces)
        {

            Debug.Log("Puzzles Completed");
            _source.PlayOneShot(_successSoundClip);
            StartCoroutine(LoadScene(sceneName));
;
        }
        IEnumerator LoadScene(string sceneName){
        yield return new WaitForSeconds(2f);
        FindObjectOfType<LevelLoader>().LoadNextLevel(sceneName);
            
    }
}}
