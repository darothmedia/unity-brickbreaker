using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Paddle paddle;

    private Vector3 paddleToBallVector;
    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = this.transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = paddle.transform.position + paddleToBallVector;

        if (Input.GetMouseButtonDown(0)){
            print("clicked");
            this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);
        };
    }
}
