using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public AudioClip crack;
    public Sprite[] hitSprites;
    public static int breakableCount = 0;
    private int timesHit;
    private bool isBreakable;
    private LevelManager levelManager;
    // Start is called before the first frame update
    void Start()
    {
        isBreakable = (this.tag == "Breakable");
        if (isBreakable){
            breakableCount++;
        }
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnCollisionEnter2D(Collision2D collision){
        if (isBreakable) {
            AudioSource.PlayClipAtPoint(crack, transform.position, 0.2f);
            HandleHits();
        }
    }

    void HandleHits(){
        int MaxHits = hitSprites.Length + 1;
        timesHit++;
        if (timesHit >= MaxHits) {
            breakableCount--;
            print(breakableCount);
            levelManager.BrickDestroyed();
            Destroy(gameObject);
        } else {
            LoadSprites();
        }
    }

    void LoadSprites(){
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex]){
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        } 
    }

    void SimulateWin(){
        levelManager.LoadNextLevel();
    }
}
