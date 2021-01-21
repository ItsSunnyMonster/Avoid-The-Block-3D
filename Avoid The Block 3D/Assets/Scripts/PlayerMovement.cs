//
// Copyright (c) SunnyMonster
// https://www.youtube.com/channel/UCbKQHYlzpR_pa5UL7JNP3kg/
//

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	#region FIELDS

    public Rigidbody playerRb;
    public Transform cameraTransform;
    public Vector3 cameraOffset;
    
    public float speed = 1000f;
    public float horizontalSpeed = 100f;

    private float horizontalInput;

    #endregion

    #region UNITY CALLBACK METHODS

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        playerRb.AddForce(Vector3.forward * speed * Time.fixedDeltaTime);
        playerRb.AddForce(Vector3.right * (horizontalSpeed * horizontalInput) * Time.fixedDeltaTime, ForceMode.Impulse);
        cameraTransform.position = transform.position + cameraOffset;
    }

    #endregion

    #region METHODS

    

    #endregion
}