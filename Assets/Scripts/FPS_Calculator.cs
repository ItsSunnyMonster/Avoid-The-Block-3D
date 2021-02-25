//
// Copyright (c) SunnyMonster
// https://www.youtube.com/channel/UCbKQHYlzpR_pa5UL7JNP3kg/
//

using UnityEngine;
using TMPro;
using System.Collections;

public class FPS_Calculator : MonoBehaviour
{
    #region FIELDS

    public TextMeshProUGUI fpsText;

    #endregion

    #region UNITY CALLBACK METHODS

    private void Start()
    {
        StartCoroutine(nameof(UpdateFPS));
    }

    #endregion

    #region METHODS

    private IEnumerator UpdateFPS()
    {
        float fps;

        while (true)
        {
            fps = 1f / Time.deltaTime;

            fpsText.SetText("     " + Mathf.Floor(fps).ToString() + " FPS");

            yield return new WaitForSeconds(Random.Range(0.1f, 2f));
        }
    }

    #endregion
}