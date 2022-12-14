using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_ShowConsole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.developerConsoleVisible = true;

        S_Debugger.AddButton("Scene Maxime", ChangeSceneMaxime);
        S_Debugger.AddButton("Scene GD", ChangeSceneGD);
        S_Debugger.AddButton("Scene LD", ChangeSceneLD);
    }

    private void ChangeSceneMaxime()
    {
        SceneManager.LoadScene("Scene_Industriel");
    }
    private void ChangeSceneGD()
    {
        SceneManager.LoadScene("TestGDScene");
    }

    private void ChangeSceneLD()
    {
        SceneManager.LoadScene("Tom_Scene");
        SceneManager.LoadScene("Alexis_Blocking_Environment", LoadSceneMode.Additive);
    }
}
