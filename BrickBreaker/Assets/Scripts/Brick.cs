using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int MaxHits;
    private int timesHit;
    private LevelManager levelManager;
    // Start is called before the first frame update
    void Start()
    {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnCollisionEnter2D(Collision2D collision){
        timesHit++;
        if (timesHit == MaxHits) {
            Destroy(gameObject);
        }
        SimulateWin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SimulateWin(){
        levelManager.LoadNextLevel();
    }
}
