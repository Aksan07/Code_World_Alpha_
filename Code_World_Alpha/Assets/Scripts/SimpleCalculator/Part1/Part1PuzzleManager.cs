using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
public class Part1PuzzleManager : MonoBehaviour
{
//[SerializeField]private String sceneName;
    public int totalPuzzlePieces = 2; // Set the total number of puzzle pieces here
    private int destroyedPuzzlePieces = 0;
    
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _victorySoundClip,_destroySoundClip;
    [SerializeField] private float _waitingTime;
    [SerializeField] private GameObject defs;
    [SerializeField]private GameObject returns;
    [SerializeField]private GameObject x;
    [SerializeField]Text instruction;





public void all_pieces_destroyed(){

    destroyedPuzzlePieces++;
    _source.PlayOneShot(_destroySoundClip);
     if (destroyedPuzzlePieces >= totalPuzzlePieces)
        {
            Debug.Log("puzzles destroyed");
            _source.PlayOneShot(_victorySoundClip);
            Destroy(instruction);
            defs.GetComponent<Animator>().enabled = true;
            returns.GetComponent<Animator>().enabled = true;
            x.SetActive(false);
            
        }

//     public void PiecePlaced()
//     {
//         placedPuzzlePieces++;

//         if (placedPuzzlePieces >= totalPuzzlePieces)
//         {
//             Debug.Log("Puzzles Completed");
//             StartCoroutine(puzzleComplete());
//         }
//     }
//         public void GoToScene(string sceneName){
//        StartCoroutine(LoadAsynchronously(sceneName));
//     }
//     IEnumerator LoadAsynchronously(string sceneName){
//          AsyncOperation operations =SceneManager.LoadSceneAsync(sceneName);
//             yield return null;
// }
// IEnumerator puzzleComplete(){
    
//     _source.PlayOneShot(_victorySoundClip);
//     yield return new WaitForSeconds(_waitingTime);
//     GoToScene(sceneName);

// }

}
}
