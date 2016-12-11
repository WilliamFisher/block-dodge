using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public GameObject music;

	public void StartGame()
	{
		SceneManager.LoadScene (1);
	}

	public void Awake()
	{
		music = GameObject.Find ("Music");
		DontDestroyOnLoad (music);
	}
}