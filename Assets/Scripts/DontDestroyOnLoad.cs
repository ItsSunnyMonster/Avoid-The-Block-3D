//
// Copyright (c) SunnyMonster
// https://www.youtube.com/channel/UCbKQHYlzpR_pa5UL7JNP3kg/
//

using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    #region FIELDS



    #endregion

    #region UNITY CALLBACK METHODS

    private void Awake()
    {
        var gameObjects = GameObject.FindGameObjectsWithTag("Version and FPS");

        if (gameObjects.Length > 1)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    #endregion

    #region METHODS



    #endregion
}