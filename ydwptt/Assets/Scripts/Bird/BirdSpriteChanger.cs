using UnityEngine;
using System.Collections;

public class BirdSpriteChanger : MonoBehaviour
{
    public Sprite UpSprite;
    public Sprite DownSprite;

    public BirdController birdController;
	
	// Update is called once per frame
	void Update () 
    {
	    if (birdController.vel.y < 0)
	    {
	        (renderer as SpriteRenderer).sprite = DownSprite;
	    }
	    else
	    {
            (renderer as SpriteRenderer).sprite = UpSprite;
	    }
	}
}
