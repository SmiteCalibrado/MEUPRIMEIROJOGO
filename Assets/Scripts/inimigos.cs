using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigos : MonoBehaviour {
	int count = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {




		isPrime (count);
		count++;

	}

	public class Enemy
	{		
		private int damage;
		private int value;
		private bool isPrimo;
	
		public void atk(){
		}

		public void move (int x,int y){
		}

		public Enemy(int x , int y , int value) {
		}

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
