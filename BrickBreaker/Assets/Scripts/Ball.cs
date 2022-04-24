using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Paddle paddle;
    private bool hasStarted = false;
    private Vector3 paddleToBallVector;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = this.transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted){
            //Lock the ball relative to the paddle
            this.transform.position = paddle.transform.position + paddleToBallVector;

            //Wait for the mouse click to launch
            if (Input.GetMouseButtonDown(0)){
                print("clicked");
                this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);
                hasStarted = true;
            };
        }
        
    }
}
