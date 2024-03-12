using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    public int totalPuzzlePieces = 3; // Set the total number of puzzle pieces here
    private int placedPuzzlePieces = 0;
    public string levelname;
    public LoadSceneButton loadScene;
    

    void Start()
    {
       
    }

    public void PiecePlaced()
    {
        placedPuzzlePieces++;

        if (placedPuzzlePieces >= totalPuzzlePieces)
        {
            LevelComplete();
        }
    }

    void LevelComplete()
    {
        // Show the level complete message
       loadScene.GoToScene(levelname);
        // You can also perform other actions such as loading the next level or resetting the current level
    }
}
