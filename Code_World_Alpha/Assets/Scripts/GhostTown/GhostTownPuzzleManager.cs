using UnityEngine;
using UnityEngine.UI;

public class GhostTownPuzzleManager : MonoBehaviour
{
    public int totalPuzzlePieces = 4; // Set the total number of puzzle pieces here
    private int placedPuzzlePieces = 0;
    //public string levelname;
   // public LoadSceneButton loadScene;
   public Text instructions;
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _ghostSound;

    



    public void PiecePlaced()
    {
        placedPuzzlePieces++;

        if (placedPuzzlePieces >= totalPuzzlePieces)
        {
            Debug.Log("Puzzles Completed");

            instructions.enabled=false;
            _source.PlayOneShot(_ghostSound);


           // LevelComplete();
        }
    }

    // void LevelComplete()
    // {
    //     // Show the level complete message
    //    loadScene.GoToScene(levelname);
    //     // You can also perform other actions such as loading the next level or resetting the current level
    // }
}
