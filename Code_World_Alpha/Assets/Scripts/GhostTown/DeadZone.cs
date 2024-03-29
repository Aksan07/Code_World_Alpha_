
using UnityEngine;


public class DeadZone : MonoBehaviour
{
    public float deadzone;
    public Animator slotAnimator;
     void Update()
{
    if (transform.position.y<deadzone){
        slotAnimator.enabled = true;
        Destroy(gameObject);
    }
            
}
    }

