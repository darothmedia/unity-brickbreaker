using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public static int lives = LoseCollider.lifeNum;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void decreaseLife(){
        Destroy(gameObject);
        lives--;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
