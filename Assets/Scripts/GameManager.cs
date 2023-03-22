
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static float timeElapsed; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        Debug.Log("#### time: " + Time.deltaTime);
    }

    public void OnLose(){
        Invoke("GoToMainMenu", 1);
    }

    public void GoToMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
