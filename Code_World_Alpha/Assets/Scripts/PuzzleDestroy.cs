using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleDestroy : MonoBehaviour
{
    private bool _dragging;
    private Vector2 _offset, _originalPosition;
    private PuzzleManager puzzleManager;
    public string tagName;
    public Text dialogue;

    void Awake()
    {
        _originalPosition = transform.position; // Assign the original position of the object
        puzzleManager = FindObjectOfType<PuzzleManager>();
    }

    void Update()
    {
        if (!_dragging) return;

        var mousePosition = GetMousePos();
        transform.position = mousePosition - _offset;
    }

    void OnMouseDown()
    {
        _dragging = true;
        _offset = GetMousePos() - (Vector2)transform.position;

        // Disable animation
        Animator animator = GetComponent<Animator>();
        if (animator != null)
        {
            animator.enabled = false;
        }
    }

    void OnMouseUp()
    {
        if (!_dragging) return;

        // Check if the dragged object is colliding with the slot
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.1f);
        bool droppedOnSlot = false;
        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject.CompareTag(tagName))
            {
                // Snap the dragged object to the position of the slot
                transform.position = collider.transform.position;
                droppedOnSlot = true;
                break;
            }
        }

        if (!droppedOnSlot)
        {
            // If not dropped on the slot, reset the position
            transform.position = _originalPosition;
            dialogue.text = "Try Again";
        }
        else
        {
            // If dropped on the slot, destroy the object and update dialogue
            Destroy(gameObject);
            puzzleManager.PiecePlaced();
            dialogue.text = "Good Job";
        }

        _dragging = false;
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
