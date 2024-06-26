using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class BGmusic : MonoBehaviour
{


    [SerializeField]string levelname;

    public static BGmusic Instance { get; private set; }

    void Awake()
    {
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

             if (SceneManager.GetActiveScene().name == levelname)
                Destroy(gameObject);
    }
}