using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static MusicPlayer instance = null;

    void Awake(){
        if (instance){
            Destroy (gameObject);
            print("Duplicate music player self-destructing");
        } else {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        };
    }
    void Start(){}

    // Update is called once per frame
    void Update(){}
}
