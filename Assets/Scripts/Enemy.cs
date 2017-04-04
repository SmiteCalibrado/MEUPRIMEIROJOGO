using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssemblyCSharp;

namespace AssemblyCSharp
{
	public class Enemy 
	{
		private int damage;
		private int value;
		private bool isPrimo;
		public Vector2 position;

		public void atk(){
		}

		public void move (int x,int y){
		}

		public Enemy(float x , float y , int value) {
			position = new Vector2 (x, y);
		}


	}
}

