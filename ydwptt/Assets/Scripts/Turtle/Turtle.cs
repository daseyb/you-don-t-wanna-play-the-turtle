using UnityEngine;
using System.Collections;

public class Turtle : MonoBehaviour {

    private const float TurtleSpeedAdd = 0.2f;
    private const float TurtleMaxSpeed = 1.0f;
    private const float SetBackSpeed = 1.0f;
    private const float SetBackSpeedUp = 0.8f;
    private const float BounceFactor = 0.6f;
    private const float Friction = 2.0f;

    private float m_JoustAngle = 0.0f;
    private const float JoustAdd = 3.0f;
    private const float JoustDecay = 0.1f;
    private const float Gravity = 9.81f;

    private const float FloorY = 0.9f;

    private Vector2 m_Velocity = new Vector2();

    public GameObject m_Joust = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //MOVEMENT
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (this.m_Velocity.x > 0.0f || this.m_Velocity.magnitude < TurtleMaxSpeed)
            {
                this.m_Velocity += -Vector2.right * TurtleSpeedAdd;
            }

            this.m_Joust.transform.rotation = Quaternion.RotateTowards(this.m_Joust.transform.rotation, Quaternion.Euler(new Vector3(0, 0, -45.0f)), JoustAdd);
        }

        //JOUST DECAY
        this.m_Joust.transform.rotation = Quaternion.RotateTowards(this.m_Joust.transform.rotation, Quaternion.Euler(new Vector3(0, 0, 0.0f)), JoustDecay);

        //GROUND COLLISION
        if (this.transform.position.y <= FloorY)
        {
            Vector3 trans = this.transform.position;
            trans.y = FloorY;
            this.transform.position = trans;
            this.m_Velocity = new Vector2(m_Velocity.x, m_Velocity.y * -BounceFactor);

            //FRICTION
            this.m_Velocity.x -= this.m_Velocity.x * Friction * Time.deltaTime;
        }
        else
        {
            ///GRAVITY

            this.m_Velocity += -Vector2.up * Gravity * Time.deltaTime;
        }


        //DEBUG
        if (Input.GetKeyDown(KeyCode.P))
        {
            SetBack();
        }

        //ASSIGNMENT
        Vector3 Vel3D = this.m_Velocity;
        this.transform.position += Vel3D * Time.deltaTime;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("BirdLance"))
        {
            SetBack();
        }
    }

    public void SetBack()
    {
        m_Velocity += Vector2.right * SetBackSpeed;
        m_Velocity += Vector2.up * SetBackSpeedUp;
    }
}
