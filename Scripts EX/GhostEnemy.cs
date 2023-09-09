using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class GhostEnemy : MonoBehaviour
{
	public Transform Target;
	public float Speed = 2.5f;

	private void Update()
	{
		if (Target != null)
		{
			//zanimljivo pogledat matematiku iza toga
			transform.LookAt(Target);
			transform.position += transform.forward * Speed * Time.deltaTime;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			PlayerLives playerLives = other.GetComponent<PlayerLives>();

			if (playerLives != null)
			{
				playerLives.Die();
			}

			Destroy(gameObject);
		}
	}
}
