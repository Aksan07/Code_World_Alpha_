using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelLoader : MonoBehaviour
{
public Animator transition;
  public float transitonTime=1f;
[SerializeField] string sceneName;

//   void Update()
//   {
//    if(Input.GetMouseButtonDown(0))
//       {
//         LoadNextLevel();
//       }
//   }
 public void LoadNextLevel(string sceneName)
 {
  StartCoroutine(LoadLevel(sceneName));
 }
 IEnumerator LoadLevel(string sceneName)
 {
  transition.SetTrigger("Start");
  yield return new WaitForSeconds(transitonTime);
  SceneManager.LoadScene(sceneName); 
 }

}
