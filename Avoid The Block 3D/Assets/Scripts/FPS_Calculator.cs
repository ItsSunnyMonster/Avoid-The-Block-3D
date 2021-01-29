//
// Copyright (c) SunnyMonster
// https://www.youtube.com/channel/UCbKQHYlzpR_pa5UL7JNP3kg/
//

using UnityEngine;
using TMPro;

public class FPS_Calculator : MonoBehaviour
{
    #region FIELDS

    public TextMeshProUGUI fpsText;

    #endregion

    #region UNITY CALLBACK METHODS

    private void Update()
    {
        UpdateFPS();
    }

    #endregion

    #region METHODS

    private void UpdateFPS()
    {
        var fps = 1f / Time.deltaTime;

        fpsText.SetText("     " + Mathf.Floor(fps).ToString() + " FPS");
    }

    #endregion
}