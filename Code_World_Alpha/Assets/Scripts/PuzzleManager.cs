using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    public int totalPuzzlePieces = 3; // Set the total number of puzzle pieces here
    private int placedPuzzlePieces = 0;
    public Text levelCompleteText; // Reference to the UI text element displaying the level complete message

    void Start()
    {
        levelCompleteText.gameObject.SetActive(false); // Hide the level complete message at the start
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
        levelCompleteText.gameObject.SetActive(true);
        // You can also perform other actions such as loading the next level or resetting the current level
    }
}
