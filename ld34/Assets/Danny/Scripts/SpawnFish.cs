using UnityEngine;
using System.Collections;


public class SpawnFish : MonoBehaviour {
	public GameObject[] Fishes;



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	public void spawn()
	{
		Instantiate(Fishes[Random.Range(0,Fishes.Length)],this.transform.position,Quaternion.identity);

	}
	void OnBecameInvisible(){
		
	Destroy(gameObject);
	}
}
