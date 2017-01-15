using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gameControl : MonoBehaviour {

	public static gameControl instance;
	public GameObject gameOverTest;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;
	public Text scoreT;

	private int score = 0;

	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver == true && Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void BirdScored() {
		if (gameOver) {
			return;
		}
		score++;
		scoreT.text = "Score: " + score.ToString ();
	}

	public void BirdDied () {
		gameOverTest.SetActive (true);
		gameOver = true;
	}
}
