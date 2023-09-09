using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryZone : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			int sceneBuildIndex = SceneManager.GetActiveScene().buildIndex;

			//Failed Implementation try when have time
			//if (other.CompareTag("ForwardScene")) 
			//{ 
			SceneManager.LoadScene(sceneBuildIndex + 1);
			//}
			

			//else if (other.CompareTag("BackwardScene"))
   //         {
			//	SceneManager.LoadScene(sceneBuildIndex + 1);
			//}
		}
	}
}
