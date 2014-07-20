using UnityEngine;
using System.Collections;

// this make the unity editor create a box collider2d when you drag the script to a gameobject
[RequireComponent(typeof(BoxCollider2D))]
public class ScoreZone : MonoBehaviour {
	// now you can drag the scoreboard from the editor instead of using a tag or a name
	public Scoreboard scoreboard;
	
	void Start() {
		// you shoud probably do it on the editor instead of here but just to be safe
		collider2D.isTrigger = true;
	}

	// this is called when something enter the collider
	void OnTriggerEnter2D(Collider2D go) {
		// this check if the colliding object is the ball
		Debug.Log(go.gameObject.name == "Ball");
		if (go.gameObject.name == "Ball") {
			// this destroy the ball after 0.3 second. the time is just to make the ball move a bit after hitting the paddle
			Destroy(go.gameObject, 0.3f);
			// this call the function that add the point to player
			scoreboard.ScorePoint(1);
		}
	}
}