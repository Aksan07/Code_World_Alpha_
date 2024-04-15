using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RemoveKeyword : MonoBehaviour
{
      private Part1PuzzleManager puzzleManager;

    //[SerializeField] public string tag_name;
    

public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered");
        Destroy(gameObject);
        puzzleManager.all_pieces_destroyed();
    }

    public void Awake()
    {
        puzzleManager = FindObjectOfType<Part1PuzzleManager>();
    }
}
