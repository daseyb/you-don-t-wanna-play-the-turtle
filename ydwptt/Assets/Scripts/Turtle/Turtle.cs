using UnityEngine;
using System.Collections;

public class Turtle : MonoBehaviour {

    private const float TurtleSpeedAdd = 0.2f;
    private const float TurtleMaxSpeed = 1.0f;
    private const float SetBackSpeed = 1.0f;
    private const float SetBackSpeedUp = 0.8f;
    private const float BounceFactor = 0.6f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //MOVEMENT
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (this.rigidbody2D.velocity.magnitude < TurtleMaxSpeed)
            {
                this.rigidbody2D.velocity += -Vector2.right * TurtleSpeedAdd;
            }
        }

        //GROUND COLLISION
        if (this.transform.position.y <= 0.0f)
        {
            Vector3 trans = this.transform.position;
            trans.y = 0.0f;
            this.transform.position = trans;
            Vector2 rigidVel = this.rigidbody2D.velocity;
            this.rigidbody2D.velocity = new Vector2(rigidVel.x, rigidVel.y * BounceFactor);
        }


        //DEBUG
        if (Input.GetKeyDown(KeyCode.P))
        {
            SetBack();
        }
	}

    public void SetBack()
    {
        this.rigidbody2D.velocity += Vector2.right * SetBackSpeed;
        this.rigidbody2D.velocity += Vector2.up * SetBackSpeedUp;
    }
}
