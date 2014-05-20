using UnityEngine;
using System.Collections;

public class GameControls : MonoBehaviour {
    public static KeyCode TURTLE_KEY { get; private set; }
    public static KeyCode BIRD_KEY { get; private set; }
    // Use this for initialization
	void Start ()
    {
	    if (Random.value < 0.5f)
	    {
	        TURTLE_KEY = KeyCode.S;
            BIRD_KEY = KeyCode.L;
        }
	    else
	    {
            TURTLE_KEY = KeyCode.L;
            BIRD_KEY = KeyCode.S;
	    }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
