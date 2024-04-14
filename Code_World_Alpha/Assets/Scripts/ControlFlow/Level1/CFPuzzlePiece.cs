using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CFPuzzlePiece : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _pickUpClip,_errorSoundClip,_successSoundClip;

    private bool _dragging;
    private Vector2 _offset, _originalPosition;
    private CFPuzzleManager cfpuzzleManager;
    public string tagName;
    

    void Awake()
    {
        _originalPosition = transform.position;
        cfpuzzleManager = FindObjectOfType<CFPuzzleManager>();
        
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
    _source.PlayOneShot(_pickUpClip);
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
                _source.PlayOneShot(_successSoundClip);
                // Snap the dragged object to the position of the slot
                transform.position = collider.transform.position;
                // Disable dragging
                _dragging = false;
                GetComponent<BoxCollider2D>().enabled=false;
                cfpuzzleManager.PiecePlaced();
                return;
            }
        }
        // If not dropped on the slot, reset the position
        transform.position = _originalPosition;
        _dragging = false;
        _source.PlayOneShot(_errorSoundClip);
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}