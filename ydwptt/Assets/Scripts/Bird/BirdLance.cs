using UnityEngine;
using System.Collections;

public class BirdLance : MonoBehaviour
{
    public BirdController bird;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("TurtleLance"))
        {
            bird.vel.y = 10;
            transform.localRotation = Quaternion.identity;
        }
    }
}
