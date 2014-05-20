using UnityEngine;
using System.Collections;

public class BirdController : MonoBehaviour
{
    public float XVelocity;
    public float TapImpulse;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            var vel = rigidbody2D.velocity;
            vel.y = TapImpulse;
            rigidbody2D.velocity = vel;
        }

        if (transform.position.y > 15 || transform.position.y < 0)
        {
            Application.LoadLevel(0);
        }

        if (transform.position.x < -10)
        {
            transform.position = new Vector2(11, transform.position.y);
        }
    }

	void FixedUpdate ()
	{
	    var vel = rigidbody2D.velocity;
	    vel.x = XVelocity;
	    rigidbody2D.velocity = vel;
	}
}
