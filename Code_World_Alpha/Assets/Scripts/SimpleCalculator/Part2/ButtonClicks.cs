using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ButtonClicks : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _errorSoundClip,_successSoundClip;
    [SerializeField] GameObject printobj,buttonobj,correctbutton;
    [SerializeField]Text question;
    [SerializeField] string sceneName;
    
public void buttonClickcorrect(){
    Debug.Log("button has been clicked");
    _source.PlayOneShot(_successSoundClip);
    question.text="Okieee...Now I Remember ";
    //correctbutton.GetComponent<Animator>().enabled = true;
    printobj.GetComponent<Animator>().enabled=true;
    buttonobj.GetComponent<Animator>().enabled=true;
    correctbutton.GetComponent<Animator>().enabled=true;
    StartCoroutine(destroyobj(buttonobj));
    StartCoroutine(destroyobj(correctbutton));
    GoToScene(sceneName);
}
public void buttonClickwrong(){
    Debug.Log("wrong");
    _source.PlayOneShot(_errorSoundClip);
}
IEnumerator destroyobj(GameObject gameObject){
    yield return new WaitForSeconds(5f);
    Destroy(gameObject);
}
    public void GoToScene(string sceneName){
       StartCoroutine(LoadAsynchronously(sceneName));
    }
    IEnumerator LoadAsynchronously(string sceneName){
        yield return new WaitForSeconds(2f);
         AsyncOperation operations =SceneManager.LoadSceneAsync(sceneName);
            
         }
}
