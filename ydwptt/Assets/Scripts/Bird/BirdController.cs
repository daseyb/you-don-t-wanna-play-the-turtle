using UnityEngine;
using System.Collections;

public class BirdController : MonoBehaviour
{
    public float XVelocity;
    public float TapImpulse;

    public Vector2 vel;
    private Vector2 acc;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            vel.y = TapImpulse;
        }

        if (transform.position.y > 15 || transform.position.y < 0)
        {
            Application.LoadLevel(0);
        }

        if (transform.position.x > 10)
        {
            transform.position = new Vector2(-11, transform.position.y);
        }
    }

	void FixedUpdate ()
	{
	    vel -= Vector2.up * 30 * Time.fixedDeltaTime;
	    vel.x = XVelocity;
        transform.Translate(vel * Time.fixedDeltaTime, Space.World);
	}
}
