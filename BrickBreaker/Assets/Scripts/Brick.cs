using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int MaxHits;
    private int timesHit;
    // Start is called before the first frame update
    void Start()
    {
        timesHit = 0;
    }

    void OnCollisionEnter2D(Collision2D collision){
        timesHit++;
        if (timesHit == MaxHits) {
            Destroy(gameObject);
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
