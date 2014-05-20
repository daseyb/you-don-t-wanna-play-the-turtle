using UnityEngine;
using System.Collections;

public class EscapeToQuit : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if(Input.anyKeyDown)
        {
            Application.LoadLevel("Menu");
        }
    }
}
