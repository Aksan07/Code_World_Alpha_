using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieceGhostCustom : MonoBehaviour
{
private bool _dragging;
    private Vector2 _offset, _originalPosition;
    //private PuzzleManager puzzleManager;
    public string tagName;

    void Awake()
    {
        _originalPosition = transform.position;
        //puzzleManager = FindObjectOfType<PuzzleManager>();
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
    }

    void OnMouseUp()
    {
        if (!_dragging) return;

        // Check if the dragged object is colliding with the slot
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.1f);
        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject.CompareTag(tagName))
            {
                // Snap the dragged object to the position of the slot
                transform.position = collider.transform.position;
                // Disable dragging
                _dragging = false;
                GetComponent<BoxCollider2D>().enabled = false;
               // puzzleManager.PiecePlaced();
               Destroy(gameObject);

                // Call OnPiecePlaced method of the slot object
                SlotAnimationTrigger slot = collider.GetComponent<SlotAnimationTrigger>();
                if (slot != null)
                {
                    slot.OnPiecePlaced();
                }


                return;
            }
        }
        // If not dropped on the slot, reset the position
        transform.position = _originalPosition;
        _dragging = false;
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
