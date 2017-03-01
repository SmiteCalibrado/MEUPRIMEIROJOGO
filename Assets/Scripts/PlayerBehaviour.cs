using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {



	//Movimentacao
	public float speed;
	public float maxSpeed;
	private Rigidbody2D rigibodyPlayer;

	// Use this for initialization
	void Start () {
		rigibodyPlayer = GetComponent<Rigidbody2D> (); 

	}

	// Update is called once per frame
	void Update () {

		Vector2  inputDirectionX = new Vector2 (Input.GetAxis ("Horizontal")*speed, 0);
		Vector2  inputDirectionY = new Vector2 (0,Input.GetAxis ("Vertical")*speed );


		rigibodyPlayer.AddForce (inputDirectionX);

		if (rigibodyPlayer.velocity.x > maxSpeed) {
			rigibodyPlayer.velocity = new Vector2(maxSpeed, rigibodyPlayer.velocity.y);		
		}

		if (rigibodyPlayer.velocity.x < -maxSpeed) {
			rigibodyPlayer.velocity = new Vector2 (-maxSpeed, rigibodyPlayer.velocity.y);

		}

		rigibodyPlayer.AddForce (inputDirectionY);

		if(rigibodyPlayer.velocity.y > maxSpeed){
			rigibodyPlayer.velocity = new Vector2 (rigibodyPlayer.velocity.x, maxSpeed);
		}


		if (rigibodyPlayer.velocity.y < -maxSpeed) {
			rigibodyPlayer.velocity = new Vector2 (rigibodyPlayer.velocity.x,-maxSpeed);

		}

	}
}