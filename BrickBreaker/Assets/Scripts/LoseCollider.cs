using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    private LevelManager levelManager;
    private GameObject lives;
    private List<GameObject> lifeArray;
    public static int lifeNum = 3;

    void Start(){
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        lives = GameObject.Find("Lives");
        lifeArray = new List<GameObject>();
        for(int i = 0; i<lifeNum; i++){
            GameObject life = lives.transform.GetChild(i).gameObject;
            lifeArray.Add(life);
        }
        for (int i = 0; i < lifeNum - Life.lives;i++){
            Destroy(lifeArray[lifeNum - i - 1]);
        }
    }

    void OnTriggerEnter2D(Collider2D trigger){
        Life.lives--;
        if (Life.lives == 0){
            levelManager.Lose();
            Life.lives = lifeNum;
            Ball.hasStarted = false;
        } else {
            Destroy(lifeArray[Life.lives]);
            Ball.hasStarted = false;
        }
    }
}
