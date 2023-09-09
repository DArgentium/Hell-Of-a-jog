using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
	public void RestartLevel()
	{
		int sceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(sceneBuildIndex);
	}
}
