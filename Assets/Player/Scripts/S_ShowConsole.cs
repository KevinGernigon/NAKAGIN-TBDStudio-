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

        S_Debugger.AddButton("Test", DebugTest);

        S_Debugger.AddButton("Scene Maxime", ChangeSceneMaxime);
        S_Debugger.AddButton("Scene GD", ChangeSceneGD);
    }

    private void DebugTest()
    {
        S_Debugger.Log("Coucou");
    }

    private void ChangeSceneMaxime()
    {
        SceneManager.LoadScene("Scene_Industriel");
    }
    private void ChangeSceneGD()
    {
        SceneManager.LoadScene("TestGDScene");
    }
}
