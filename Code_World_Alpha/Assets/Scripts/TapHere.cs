using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;
using UnityEngine.UI;
public class EnableButtonAfterDelay : MonoBehaviour
{
 [SerializeField]private String sceneName;
   // Update is called once per frame
    void Update()
    {
        OnMouseOver();
    }
    void OnMouseOver(){
        if (Input.GetMouseButtonDown(0)){
            
            GoToScene(sceneName);
        }
    }
    public void GoToScene(string sceneName){
       StartCoroutine(LoadAsynchronously(sceneName));
    }
    IEnumerator LoadAsynchronously(string sceneName){
         AsyncOperation operations =SceneManager.LoadSceneAsync(sceneName);
            yield return null;
         }
}
