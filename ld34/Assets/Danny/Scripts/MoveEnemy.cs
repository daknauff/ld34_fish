using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour {
	public int movespeed;
	float variospeed;

	// Use this for initialization
	void Start () {
		variospeed=Random.Range(1,3);
	
	}
	
	// Update is called once per frame
	void Update () {
		float x_auto = Time.deltaTime*(movespeed*variospeed);
		Debug.Log(x_auto);
		transform.Translate(x_auto,0,0);
	
	}
	void OnBecameInvisible(){

		Destroy(gameObject);
	}
}
