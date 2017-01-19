using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    public bool autoPlay = false;

    private Ball ball;

    private void Start() {
        ball = GameObject.FindObjectOfType<Ball>();
    }

	void Update () {
        if (!autoPlay)
            MoveWithMouse();
        else
            AutoPlay();
	}

    void MoveWithMouse() {
       Vector3 paddleVector = new Vector3(0.5f, this.transform.position.y, 0);
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        paddleVector.x = Mathf.Clamp(mousePosInBlocks, 1.18f, 14.8f);
        this.transform.position = paddleVector; //this is the instance of current script
    }

    void AutoPlay() {
        Vector3 paddleVector = new Vector3(0.5f, this.transform.position.y, 0);
        Vector3 ballPos = ball.transform.position;
        paddleVector.x = Mathf.Clamp(ballPos.x, 1.18f, 14.8f);
        this.transform.position = paddleVector; //this is the instance of current script
    }
}
