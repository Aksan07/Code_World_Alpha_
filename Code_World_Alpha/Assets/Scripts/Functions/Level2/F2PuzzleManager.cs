using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F2PuzzleManager : MonoBehaviour
{
public int totalPuzzlePieces = 2; // Set the total number of puzzle pieces here
    private int placedPuzzlePieces = 0;
    //public string levelname;
   // public LoadSceneButton loadScene;
   //[SerializeField] Text instructions;
    // [SerializeField] private AudioSource _source;
    // [SerializeField] private AudioClip _ghostSound;

    public void PiecePlaced()
    {
        placedPuzzlePieces++;

        if (placedPuzzlePieces >= totalPuzzlePieces)
        {
            Debug.Log("Puzzles Completed");

            //instructions.enabled=false;
           // LevelComplete();
        }
    }
}
