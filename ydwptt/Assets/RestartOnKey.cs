using UnityEngine;
using System.Collections;

public class RestartOnKey : MonoBehaviour
{
    private float timer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    timer += Time.deltaTime;
	    if (Input.anyKeyDown && timer > 2.0f)
	    {
	        Application.LoadLevel("Main");
	    }
	}
}
