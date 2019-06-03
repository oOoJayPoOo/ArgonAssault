using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
	void Start ()
	{
		Invoke("LoadGame", 3);
	}

	void LoadGame()
	{
		SceneManager.LoadScene("Level 1");
	}
}
