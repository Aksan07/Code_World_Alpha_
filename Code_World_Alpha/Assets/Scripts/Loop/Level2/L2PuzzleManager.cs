using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2PuzzleManager : MonoBehaviour
{
public int totalPuzzlePieces = 2; // Set the total number of puzzle pieces here
    private int placedPuzzlePieces = 0;
    [SerializeField] string sceneName;


    public void PiecePlaced()
    {
        placedPuzzlePieces++;

        if (placedPuzzlePieces >= totalPuzzlePieces)
        {
             FindObjectOfType<LevelLoader>().LoadNextLevel(sceneName);

            //instructions.enabled=false;
           // LevelComplete();
        }
    }
}
