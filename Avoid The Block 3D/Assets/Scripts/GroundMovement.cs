//
// Copyright (c) SunnyMonster
// https://www.youtube.com/channel/UCbKQHYlzpR_pa5UL7JNP3kg/
//

using UnityEngine;

public class GroundMovement : MonoBehaviour
{
	#region FIELDS

	public Transform groundTransform;

   	#endregion

   	#region UNITY CALLBACK METHODS

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			groundTransform.Translate(Vector3.forward * 2000);
		}
	}

	#endregion

   	#region METHODS



   	#endregion
}