using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public Text LevelName;

	public Canvas LevelOverCanvas;

	private void Start()
	{
		LevelName.text = SceneManager.GetActiveScene().name;
		LevelOverCanvas.enabled = false;
	}

	private void Update()
	{
	}

	public void SetLevelOver()
	{
		LevelOverCanvas.enabled = true;
	}
}
