using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
	void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

	void Start ()
	{
		Invoke("LoadGame", 3);
	}

	void LoadGame()
	{
		SceneManager.LoadScene("Level 1");
	}
}
