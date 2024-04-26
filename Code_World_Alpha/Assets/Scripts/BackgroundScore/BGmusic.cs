using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class BGmusic : MonoBehaviour
{
    public static BGmusic instance;
    [SerializeField]string levelname;


 
    void Awake()
    {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            
    }
    void Update(){

             if (SceneManager.GetActiveScene().name == levelname)
                Destroy(gameObject);
    }
}