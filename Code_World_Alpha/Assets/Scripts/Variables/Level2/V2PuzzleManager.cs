using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V2PuzzleManager : MonoBehaviour
{
    [SerializeField] int totalPuzzlePieces = 2; // Set the total number of puzzle pieces here
    private int deletedPuzzlePieces = 0;
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _successSoundClip;


    public void PieceDeleted()
    {
        deletedPuzzlePieces++;

        if (deletedPuzzlePieces >= totalPuzzlePieces)
        {

            Debug.Log("Puzzles Completed");
            _source.PlayOneShot(_successSoundClip);
;
        }
    }
}
