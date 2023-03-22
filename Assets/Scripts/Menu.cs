using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
   
    public void goToGameScene () {
        SceneManager.LoadScene("Game");  // charge another scene
    }

    public void ExitGame () {
        Debug.Log("Exit Game");
        Application.Quit(); //this only work on build
    }


}
