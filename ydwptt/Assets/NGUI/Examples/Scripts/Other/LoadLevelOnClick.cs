using UnityEngine;
using System.Collections;

[AddComponentMenu("NGUI/Examples/Load Level On Click")]
public class LoadLevelOnClick : MonoBehaviour
{
    public float MinLoadTime = 1.0f;
	public string levelName;
    public string sceneName;

	void OnClick ()
	{
		if (!string.IsNullOrEmpty(levelName))
		{
            PlayerPrefs.SetString("LevelToLoad", levelName);
		}

        PlayerPrefs.SetInt("LoadedFromEditor", 0);

	    if (MinLoadTime > 0)
	    {
            StartCoroutine(LoadAsync(MinLoadTime));       
	    }
	    else
	    {
	        Application.LoadLevel(sceneName);
	    }
	}
    
    IEnumerator LoadAsync(float _time)
    {
        var op = Application.LoadLevelAsync(sceneName);
        op.allowSceneActivation = false;

        yield return new WaitForSeconds(_time);

        op.allowSceneActivation = true;
    }
}