using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerLives : MonoBehaviour
{
	public Vector3 RespawnPosition;
	//Rigidbody rb;
	private void Start()
	{
		RespawnPosition = transform.position;
	}


	public void Die()
	{

			transform.position = RespawnPosition;
	
	}
}
