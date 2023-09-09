using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTrigger : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			GhostEnemy ghostEnemy = GetComponentInParent<GhostEnemy>();
			ghostEnemy.Target = other.transform;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			GhostEnemy ghostEnemy = GetComponentInParent<GhostEnemy>();
			ghostEnemy.Target = null;
		}
	}
}
