//
// Copyright (c) SunnyMonster
// https://www.youtube.com/channel/UCbKQHYlzpR_pa5UL7JNP3kg/
//

using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetector : MonoBehaviour
{
    #region FIELDS

    public PlayerMovement playerMovement;

    public float reactionTime = 2f;

    #endregion

    #region UNITY CALLBACK METHODS

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            playerMovement.enabled = false;
            // Invoke(nameof(GameOver), reactionTime);
        }
    }

    #endregion

    #region METHODS

    // private void GameOver()
    // {
    //     SceneManager.LoadScene("Game Over");
    // }

    #endregion
}