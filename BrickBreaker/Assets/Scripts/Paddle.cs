using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    public bool autoPlay = false;
    private Ball ball;

    void Start(){
        ball = GameObject.FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!autoPlay){
            MoveWithMouse();
        } else {
            AutoPlay();
        }
    }

    void AutoPlay(){
        Vector3 paddlePos = new Vector3(0f, this.transform.position.y, 0f);
        Vector3 ballPos = ball.transform.position;
        paddlePos.x = Mathf.Clamp(ballPos.x, -6.25f, 6.25f);
        this.transform.position = paddlePos;
    }

    void MoveWithMouse(){
        Vector3 paddlePos = new Vector3(0f, this.transform.position.y, 0f);
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        paddlePos.x = Mathf.Clamp(mousePosInBlocks - 8, -6.25f, 6.25f);
        this.transform.position = paddlePos;
    }
}
