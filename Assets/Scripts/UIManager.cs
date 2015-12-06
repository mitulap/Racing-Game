using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

	public Text scoreText;

	public Button [] buttons;
	bool gameOver;

	int score;



	// Use this for initialization
	void Start () {
		gameOver = false;
		score = 0;
		InvokeRepeating ("ScoreUpdate", 1f, 1f);

	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score : " + score;	
	}


	void ScoreUpdate(){
		if (!gameOver) {
			score += 1;
		}
	}

	public void GameOver(){

		gameOver = true;

		foreach (Button btn in buttons) {
			btn.gameObject.SetActive(true);
		}
	}

	public void Play(){
		Application.LoadLevel("level1");

	}

	public void Pause(){

		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} else if (Time.timeScale == 0) {
			Time.timeScale = 1;
		}
	}

	public void Replay(){

		Application.LoadLevel (Application.loadedLevel);
	}

	public void Menu(){
		Application.LoadLevel ("menuScene");
	}

	public void Exit(){
		Application.Quit ();
	}

}
