//
// Copyright (c) SunnyMonster
// https://www.youtube.com/channel/UCbKQHYlzpR_pa5UL7JNP3kg/
//

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region FIELDS

    

    #endregion

    #region UNITY CALLBACK METHODS



    #endregion

    #region METHODS

    #region BUTTON EVENTS

    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }

    public void Quit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
        Application.OpenURL("https://google.com");
        #else
        Application.Quit();
        #endif
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    #endregion

    #endregion
}