using UnityEngine;
using System.Collections;

public class TurtleHead : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("BirdLance"))
        {
            Application.LoadLevel(0);
        }
    }
}
