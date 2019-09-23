using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {

    public string newGameLevel;

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void ReturnMenu()
    {
        LoadEnd();
    }

    public void LoadEnd()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
