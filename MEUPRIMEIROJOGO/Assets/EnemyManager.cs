using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
	public GameObject enemy;    //Objeto onde inimigo Spawna
	public float spawnTime = 3f; //Tempo De Spawn
	public Transform[] spawnPoints;// Lugares do Spawn




	void Start () {

		InvokeRepeating ("Spawn", spawnTime, spawnTime);
		
	}
	

	void Spawn () {

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
	}
}

