using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

	public void LoadScene()
    {
        SceneManager.LoadScene("Main");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadHowTo()
    {
        SceneManager.LoadScene("HowToPlay");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

}
