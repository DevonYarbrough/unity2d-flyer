using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnpool : MonoBehaviour {

	public int poolSize = 5;
	public GameObject colPrefab;
	public float spawnRate = 3f;
	public float colMin = 0f;
	public float colMax = 2.5f;

	private GameObject[] columns;
	private Vector2 objectPosition = new Vector2 (-15, -25);
	private float timer;
	private float spawnX = 10f;
	private int currCol = 0;

	void Start () {
		timer = 0f;
		columns = new GameObject[poolSize];
		for (int i = 0; i < poolSize; i++) {
			columns[i] = (GameObject)Instantiate (colPrefab, objectPosition, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (gameControl.instance.gameOver == false && timer >= spawnRate) {
			timer = 0;
			float spawnY = Random.Range(colMin, colMax);
			columns[currCol].transform.position = new Vector2(spawnX, spawnY);
			currCol++;
			if (currCol >= poolSize) {
				currCol = 0;
			}
		}
	}
}
