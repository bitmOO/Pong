using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	// Speed to be modified in the Inspector
	public float speed = 2.0f;

	float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight) {
		// ascii art:
		// || 1 <- at the top of the racket
		// || 0 <- at the middle of the racket
		// || -1 <- at the bottom of the racket
		return (ballPos.y - racketPos.y) / racketHeight;
		// we subtract the racketPos.y from the ballPos.y to have a relative position
	}

	// Use this for initialization
	void Start () {
		// Give the ball some initial movement direction
		rigidbody2D.velocity = Vector2.one.normalized * speed;
		}



	void OnCollisionEnter2D(Collision2D col) {
		// This function is called whenever the ball collides with something
		// Hit the left Racket?
		if (col.gameObject.name == "RacketLeft") {
			// Calculate hit Factor
			float y=hitFactor(transform.position, col.transform.position, ((BoxCollider2D)col.collider).size.y);

			// Calculate direction, set length to 1
			Vector2 dir = new Vector2(1, y).normalized;
			
			// Set Velocity with dir * speed
			rigidbody2D.velocity = dir * speed;
			}

		// Hit the right Racket?
		if (col.gameObject.name == "RacketRight") {
			// Calculate hit Factor
			float y=hitFactor(transform.position, col.transform.position, ((BoxCollider2D)col.collider).size.y);
			
			// Calculate direction, set length to 1
			Vector2 dir = new Vector2(-1, y).normalized;
			
			// Set Velocity with dir * speed;
			rigidbody2D.velocity = dir * speed;
			}
	}
}
