using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public void LoadLevel(string name) {
        Debug.Log("Level load requested for: "+name);
        SceneManager.LoadScene(name);
    }

    public void QuitRequest(){
        Debug.Log("Now quitting");
        Application.Quit();
    }

    public void LoadNextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BrickDestroyed(){
        if (Brick.breakableCount <= 0){
            LoadNextLevel();
            Ball.hasStarted = false;
        }
    }

    public void Lose(){
        LoadLevel("End");
    }

}
