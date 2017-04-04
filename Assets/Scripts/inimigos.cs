using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssemblyCSharp;
using System;

public class inimigos : MonoBehaviour {
	int count = 0;

	List<Enemy> enemigos = new List<Enemy> ();
	System.Random randNum = new System.Random();

	// Use this for initialization
	void Start () {
	}

	public void teste(){
		        	
	}

	// Update is called once per frame
	void Update () {

		if(Time.frameCount % 40 == 0){
			Enemy enemy = new Enemy (randNum.Next (0, Screen.width), 0, count);
			enemigos.Add (enemy);

			GameObject obj = Instantiate (gameObject) as GameObject;

			SpriteRenderer render = obj.GetComponent<SpriteRenderer> ();

			Sprite number = new Sprite ();
			render.sprite.texture.LoadImage ((Convert.FromBase64String(PlayerPrefs.GetString("SPRITE PLAYER_0"))));

			Texture2D tex = render.sprite.texture;

			number = Resources.Load ("SPRITE PLAYER", typeof(Sprite)) as Sprite;

			render.sprite = number;
			isPrime (count);
			count++;
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
