using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
	private Rigidbody2D rigibodyEnemy;

	// Use this for initialization
	void Start () {
		rigibodyEnemy = GetComponent<Rigidbody2D> ();  //Pegando Componente De Fisica
		
	}
	
	// Update is called once per frame
	void Update () {

		rigibodyEnemy.velocity = new Vector2 (rigibodyEnemy.velocity.x, -100);
		
	}
}
