using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float maxHealth = 4f;
	private float currHealth;

	void Start () {
		this.currHealth = this.maxHealth;
	}

	void OnCollisionEnter (Collision colInfo) {
		Debug.Log (colInfo.relativeVelocity.magnitude);
		if (colInfo.relativeVelocity.magnitude > this.currHealth) {
			this.myDieEnemy();
		}
	}

	void myDieEnemy () {
		Destroy (gameObject);
	}

}
