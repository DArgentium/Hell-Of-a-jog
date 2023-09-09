using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
	public GameObject DeathZoneExplosionPrefab;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			PlayerLives playerLives = other.GetComponent<PlayerLives>();

				playerLives.Die();
		}
	}
}
