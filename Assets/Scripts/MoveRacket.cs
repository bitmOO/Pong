﻿using UnityEngine;
using System.Collections;

public class MoveRacket : MonoBehaviour {
	// up and down keys (to be set in the Inspector)
	// making these public allows us to modify them in the Inspector
	public KeyCode up;
	public KeyCode down;

	// FixedUpdate is called in a fixed time interval
	void FixedUpdate() {
		// up key pressed?
		if (Input.GetKey(up)) {
			transform.Translate (new Vector2(0.0f, 0.1f));
		}

		// down key pressed?
		if (Input.GetKey(down)) {
			transform.Translate (new Vector2(0.0f, -0.1f));
		}
	}
}