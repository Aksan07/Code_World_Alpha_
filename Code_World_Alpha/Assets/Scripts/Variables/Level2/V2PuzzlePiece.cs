using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V2PuzzlePiece : MonoBehaviour
{

    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _pickUpClip,_errorSoundClip,_deleteSoundClip;

    private bool _dragging;
    private Vector2 _offset, _originalPosition;
    private V2PuzzleManager v2puzzleManager;
    public string tagName;
    

    void Awake()
    {
        _originalPosition = transform.position;
        v2puzzleManager = FindObjectOfType<V2PuzzleManager>();
        
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
                
                _dragging = false;
                GetComponent<BoxCollider2D>().enabled=false;
                StartCoroutine(destroyobj());
                v2puzzleManager.PieceDeleted();
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

    IEnumerator destroyobj(){
    _source.PlayOneShot(_deleteSoundClip);
    yield return new WaitForSeconds(1f);
    Destroy(gameObject);
}
}
