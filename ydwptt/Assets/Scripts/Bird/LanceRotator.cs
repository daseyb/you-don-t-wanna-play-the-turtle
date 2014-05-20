using UnityEngine;
using System.Collections;

public class LanceRotator : MonoBehaviour
{
    public Transform target;
	
	// Update is called once per frame
	void LateUpdate ()
	{
	    transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, 10*Time.deltaTime);
	}
}
