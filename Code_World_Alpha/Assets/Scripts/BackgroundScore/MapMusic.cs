using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapMusic : MonoBehaviour
{
    // Start is called before the first frame update
    // Instance reference (static)
    public static MapMusic Instance { get; private set; } 

    void Awake()
    {
        // Check if an instance already exists
        if (Instance == null)
        {
            // Set this as the instance and make it persist across scenes
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Destroy this object if another instance exists
            Destroy(gameObject);
        }
    }
    void Update(){

            if (SceneManager.GetActiveScene().name == "Map1")
                return;
            else if(SceneManager.GetActiveScene().name == "Map2")
                return;
            else
                Destroy(gameObject);
        
            
    }
}
