using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour {
	public int movespeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x_auto = Time.deltaTime*movespeed;
		transform.Translate(x_auto,0,0);
	
	}
	void OnBecameInvisible(){

		Destroy(gameObject);
	}
}
