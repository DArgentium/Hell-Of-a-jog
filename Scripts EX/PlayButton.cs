using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
	public void PlayGame()
	{
		int sceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(sceneBuildIndex + 1);
	}

	public void ExampleInt(int value)
	{
		Debug.Log("ExampleInt: " + value);
	}

	public void ExampleString(string name)
	{
		Debug.Log("ExampleString: " + name);
	}
}
