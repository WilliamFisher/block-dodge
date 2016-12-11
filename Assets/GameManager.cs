using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public float slowness = 10f;
	public int score = 0;
	public GameObject gameOverPanel;
	public Text score2Text;

	private Text scoreText;
	private int realScore;

	void Start()
	{
		scoreText = GameObject.Find ("Score").GetComponent<Text> ();
	}

	public void EndGame()
	{
		gameOverPanel.SetActive (true);
		score2Text.text = realScore.ToString ();
		StartCoroutine (RestartLevel ());
	}

	IEnumerator RestartLevel()
	{
		Time.timeScale = 1f / slowness;
		Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

		yield return new WaitForSeconds (2f / slowness);

		Time.timeScale = 1f;
		Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	public void IncreaseScore()
	{
		score++;
		realScore = score / 4;
		scoreText.text = realScore.ToString ();
	}
}