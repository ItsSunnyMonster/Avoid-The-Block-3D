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

    #endregion

    #endregion
}