using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Add this namespace

public class DoNotDestroy : MonoBehaviour
{
    [SerializeField] string musicTag;
 // Name of the scene where this object should be destroyed

    private void Awake()
    {
        GameObject[] musicObjects = GameObject.FindGameObjectsWithTag(musicTag);
        if (musicObjects.Length > 1)
        {
            Destroy(this.gameObject);
            return; // Exit after destroying if multiple objects exist
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}

