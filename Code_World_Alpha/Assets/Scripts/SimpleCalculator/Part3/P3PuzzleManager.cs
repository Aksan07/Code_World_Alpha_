using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3PuzzleManager : MonoBehaviour
{
[SerializeField] int totalPuzzlePieces; // Set the total number of puzzle pieces here
    private int solvedPuzzlePieces = 0;
    public void PieceSolved()
    {
        solvedPuzzlePieces++;

        if (solvedPuzzlePieces >= totalPuzzlePieces)
        {
            Debug.Log("Puzzles Completed");
        }
    }
}
