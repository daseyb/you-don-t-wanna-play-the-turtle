using UnityEngine;
using System.Collections;

public class BirdController : MonoBehaviour
{
    public float XVelocity;
    public float TapImpulse;

    public Vector2 vel;
    private Vector2 acc;

    private bool isDead = false;

    public void Activate()
    {
        enabled = true;
    }

    void Update()
    {
        if (isDead)
        {
            return;
        }

        if (Input.GetKeyDown(GameControls.BIRD_KEY))
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

    void Kill()
    {
        isDead = true;
        rigidbody2D.velocity = -vel + Vector2.up;
        rigidbody2D.gravityScale = 1;
        StartCoroutine(RestartIn(3));
    }

    IEnumerator RestartIn(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Application.LoadLevel(0);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("TurtleLance"))
        {
            Kill();
        }
    }

	void FixedUpdate ()
	{
	    if (isDead)
	    {
	        return;
	    }
	    vel -= Vector2.up * 30 * Time.fixedDeltaTime;
	    vel.x = XVelocity;
        transform.Translate(vel * Time.fixedDeltaTime, Space.World);
	}
}
