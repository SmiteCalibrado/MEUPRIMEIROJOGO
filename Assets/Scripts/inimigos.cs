using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssemblyCSharp;

public class inimigos : MonoBehaviour {
	int count = 0;

	
	// Use this for initialization
	void Start () {

	}

	public void teste(){

        System.Random randNum = new System.Random();
		List<Enemy> enemigos = new List<Enemy> ();

		for (;;) {
			enemigos.Add (new Enemy (randNum.Next(0,1000),randNum.Next(0,1000),count));
		}


	}

	// Update is called once per frame
	void Update () {




		um.move

		isPrime (count);
		count++;

	}


	private bool isPrime(int i){

			if( i <= 1 ) 					return false;
			if( i <= 3) 					return true;		
			if ( i % 2 == 0 || i % 3 == 0 )	return false;

			for(int x = 5; x*x <= i ; x = x + 6 ){
				if(i % x == 0 || i % (x + 2) == 0) return false;
			}

			return true;
		}
}
