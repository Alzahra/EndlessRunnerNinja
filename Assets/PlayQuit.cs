using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
	
    public void QuitGame ()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }

}
