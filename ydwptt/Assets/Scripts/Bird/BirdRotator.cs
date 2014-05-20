using UnityEngine;

public class BirdRotator : MonoBehaviour
{
    public BirdController target;
    public float FollowSpeed;
    public float Min;
    public float Max;

	void Update ()
	{
	    var dir = target.vel;
        dir.Normalize();
	    var zRot = Quaternion.FromToRotation(Vector2.right, dir).eulerAngles.z;
	    zRot = Mathf.Clamp(zRot, Min, Max);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, (180 - zRot)), FollowSpeed * Time.deltaTime);
	}
}
