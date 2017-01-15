using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatingbachground : MonoBehaviour {

	private BoxCollider2D groundCollider;
	private float groundLength;

	// Use this for initialization
	void Start () {
		groundCollider = GetComponent<BoxCollider2D> ();
		groundLength = groundCollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -groundLength) {
			Reposition ();
		}
	}

	private void Reposition() {
		Vector2 groundOffset = new Vector2 (groundLength * 2f, 0);
		transform.position = (Vector2)transform.position + groundOffset;
	}
}
