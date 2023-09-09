using System.Collections;
using System.Collections.Generic;

using UnityEngine;

//TODO: razmisliti i sloziti gasenje starog checkpoint
public class Checkpoint : MonoBehaviour
{	
	public Transform RespawnPositionTransform;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			PlayerLives playerLives = other.GetComponent<PlayerLives>();

			
				playerLives.RespawnPosition = RespawnPositionTransform.position;
		}
	}
}
