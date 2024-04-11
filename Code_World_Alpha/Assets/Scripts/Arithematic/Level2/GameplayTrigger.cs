using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayTrigger : MonoBehaviour
{
    [SerializeField] Animator moduloAnimator;
    [SerializeField] GameObject operators;

    void StartGamePlay(){
        moduloAnimator.enabled=true;
        operators.SetActive(true);
    }

}
