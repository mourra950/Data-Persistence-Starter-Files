using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenu : MonoBehaviour
{
    public TMP_InputField input;

    public void GameStart()
    {
        Player.name = input.text;
        if (Player.name.Length > 0)
            SceneManager.LoadScene(1);
    }
    public void GameQuit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); 
#endif
    }

}
