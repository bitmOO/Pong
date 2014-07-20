using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GUIText))]
public class Scoreboard : MonoBehaviour {

	private int score = 0;
	public GameObject ball;

	public void ScorePoint(int points) {
		// add points to actual score
		score += points;

		// set the score variable to the gui text
		guiText.text = score.ToString();

		// instantiate a new ball prefab
		GameObject newBall = Instantiate(ball, Vector3.zero, Quaternion.identity) as GameObject;

		// bit hacky. the scorezone check for the gameobject name and the new ball is called Ball (Clone) instead of just Ball
		// this change the name of the new instace of the ball gameobject
		newBall.name = "Ball";

	}
}