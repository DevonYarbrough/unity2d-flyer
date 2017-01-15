﻿using UnityEngine;
using System.Collections;

public class bird : MonoBehaviour {

	private float upForce = 200f;

	private bool isDead = false;
	private Rigidbody2D rb2d;
	private Animator anim;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isDead == false) {
			if (Input.GetMouseButtonDown (0)) {
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce (new Vector2 (0, upForce));
				anim.SetTrigger("flap");
			}
		}
	}

	void OnCollisionEnter2D ()
	{
		isDead = true;
		anim.SetTrigger ("dead");
		gameControl.instance.BirdDied();
		rb2d.velocity = Vector2.zero;
	}
}
