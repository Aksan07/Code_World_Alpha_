using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
public class GhostTownPuzzleManager : MonoBehaviour
{
    public int totalPuzzlePieces = 4; // Set the total number of puzzle pieces here
    private int placedPuzzlePieces = 0;
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _successSoundClip;
    [SerializeField]string sceneName;
    [SerializeField]GameObject cover;
    public void PiecePlaced()
    {
        placedPuzzlePieces++;

        if (placedPuzzlePieces >= totalPuzzlePieces)
        {
            Debug.Log("Puzzles Completed");
            _source.PlayOneShot(_successSoundClip);
            cover.SetActive(true);
            StartCoroutine(LoadScene(sceneName));

        }
    }
        IEnumerator LoadScene(string sceneName){
        yield return new WaitForSeconds(1f);
        FindObjectOfType<LevelLoader>().LoadNextLevel(sceneName);
            
         }


}
